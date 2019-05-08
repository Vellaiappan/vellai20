import socket
import random
import time
import cPickle as pickle
HOST = '172.22.10.219'  
PORT = 50007              # Arbitrary non-privileged port
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.bind((HOST, PORT))
s.listen(1)
conn, addr = s.accept()
print 'Connected by', addr
conn.sendall("want to send msg")
    
list1=[]
i=0

ks=random.getrandbits(15)
print "The secret key is generated and it is sending......"
from twilio.rest import TwilioRestClient
client = TwilioRestClient("ACc47c648843f50cb58049063ecf2cec93", "9be3e0ac439beeb199276fb9b84d5d26")
client.messages.create(to="+917373037444", from_="+19543200715", body=ks)


data = conn.recv(4096)
list1=pickle.loads(data)
#print list1    
z=list1[0]
n=list1[1]
print "Received publickey:",z
print "Received modulo n:",n
#print "secretkey",ks
ksr=ks
from Tkinter import *

top = Tk()
e=Entry(top)
e.pack()
e.focus_set()
def assign():
       pltxt=e.get()
       print "The plaintext is:",pltxt
       list2=[]
       list3=[]
       list4=[]
       list1=list(pltxt)
       #print list1
       for i in range(len(list1)):
           list2.append(ord(list1[i]))
       #print list2
       j=0
       while j<len(list2):
           com=list2[j]
           for i in range(9):
               if(len(list2)-j==1):
                   com=com
                   break
               else:
                   com=com*1000+list2[j+1]
                   j=j+1
           j=j+1    
           list3.append(com)
       #print list3
       
       conn.sendall(str(len(list3)))
       for i in range(len(list3)):
           cipher1=pow(list3[i],z,n)
           cipher=cipher1^ks
           list4.append(cipher)
       #print list4
       data_string=pickle.dumps(list4)
       conn.send(data_string)
       stri=''
       for i in list4:
              stri=stri+str(i)
       print "cipher=",stri    
        

b=Button(top,text="ok",command=assign)
b.pack()

mainloop()

ack=conn.recv(4096)
if(ack=='true'):
    print "The secret key is  resending......"
    from twilio.rest import TwilioRestClient
    client = TwilioRestClient("ACc47c648843f50cb58049063ecf2cec93", "9be3e0ac439beeb199276fb9b84d5d26")
    client.messages.create(to="+917373037444", from_="+19543200715", body=ksr)






time.sleep(10)
conn.close()
