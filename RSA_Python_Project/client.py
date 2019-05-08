import socket
import time
import random
from Tkinter import *
import cPickle as pickle
HOST = 'localhost'   
PORT = 50007              
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.connect((HOST, PORT))
data = s.recv(1024)
print 'Received', repr(data)

from random import randint
def is_prime(num, test_count):
    if num == 1:
        return False
    if test_count >= num:
        test_count = num - 1
    for x in range(test_count):
        val = randint(1, num - 1)
        if pow(val, num-1, num) != 1:
            return False
    return True

def generate_big_prime(n):
    found_prime = False
    while not found_prime:
        p = randint(2**(n-1), 2**n)
        if is_prime(p, 1000):
            return p

print "The Prime numbers started generating of size 50bits:"
p=generate_big_prime(512)
print "p=",p
q=generate_big_prime(512)
print "q=",q
r=generate_big_prime(512)
print "r=",r
v=generate_big_prime(512)
print "v=",v
t=generate_big_prime(512)
print "t=",t
u=generate_big_prime(512)
print "u=",u

n=p*q*r
m=v*t*u
N=n*m
pin=(p-1)*(q-1)*(r-1)
pim=(v-1)*(t-1)*(u-1)
piN=pin*pim

def gcd(a,b):
    if b==0:
        return a
    else:
        return gcd(b,a%b)
from fractions import gcd    
e1=random.randint(1,pin)
while gcd(e1,pin)!=1:
       e1=random.randint(1,pin)
print "e1=",e1
e2=random.randint(1,pim)
while gcd(e1,pim)!=1:
       e1=random.randint(1,pim)
print "e2=",e2
E1=pow(e1,e2,N)
piNE1=piN*E1
z=random.randint(1,piNE1)
while gcd(z,piNE1)!=1:
       z=random.randint(1,piNE1)
print "public key=",z

def e_gcd(aa, bb):
    lastremainder, remainder = abs(aa), abs(bb)
    x, lastx, y, lasty = 0, 1, 1, 0
    while remainder:
        lastremainder, (quotient, remainder) = remainder, divmod(lastremainder, remainder)
        x, lastx = lastx - quotient*x, x
        y, lasty = lasty - quotient*y, y
    return lastremainder, lastx * (-1 if aa < 0 else 1), lasty * (-1 if bb < 0 else 1)
 
def modinv(a, m):
	g, x, y = e_gcd(a, m)
	if g != 1:
		raise ValueError
	return x % m
    
D=modinv(z,piNE1)
print "private key=",D

input_data = []
input_data.append(z)
input_data.append(n)
datastring=pickle.dumps(input_data)
s.send(datastring)
    
cip=s.recv(4096)
length=int(cip)
#print "length=",length
list2=[]
data=s.recv(4096)
list1=pickle.loads(data)
#print list1
stri=''
for i in list1:
       stri=stri+str(i)
print "cipher=",stri   
time.sleep(5)
def inputvalue():
    while True:
     try:
         ks = int(raw_input("Please enter secret key: "))
         break
     except ValueError:
         print "Oops!  That was no valid number.  Try again..."
   
    return ks
status=0
then=time.time()
ks=inputvalue()
now=time.time()
diff=int(now-then)
if(diff>20):
    print "secretkey expired"
    ack=raw_input("Forgot-Wanted secret key again(true/false-to quit process):")
    if(ack=='true'):
        s.sendall(ack)
        status=1
    else:
        status=2

if(status==1):
    time.sleep(10)
    then=time.time()
    ks=inputvalue()
    now=time.time()
    diff=int(now-then)
    if(diff>15):
        print "secretkey expired again so restart the process"
        time.sleep(10)
        s.close()
    else:
        for i in list1:
            cipher=i^ks
            plain=pow(cipher,D,n)
            list2.append(plain)
        #print list2    
        list3=[]
        j=0
        while j<len(list2):
            quotient=list2[j]
            re=quotient%1000
            list4=[]
            list4.append(re)
            for i in range(9):
                quotient=quotient/1000
                rem=quotient%1000
                if(rem!=0):
                    list4.append(rem)
            for k in reversed(list4):
                list3.append(k)
            j=j+1
        #print list3
        strin=''
        try:
            for i in list3:
                strin=strin+str(chr(i))
        except ValueError:
             strin="Oops!  Sorry Hacker.Better Luck next time"        
        root = Tk()
        text = Text(root)
        text.insert(INSERT, "PlainText:")
        text.insert(END,strin)
        text.pack()
        root.mainloop()
        time.sleep(15)
        s.close()
                

        
if(status==0):
    s.sendall('false')

    for i in list1:
        cipher=i^ks
        plain=pow(cipher,D,n)
        list2.append(plain)
    #print list2    
    list3=[]
    j=0
    while j<len(list2):
        quotient=list2[j]
        re=quotient%1000
        list4=[]
        list4.append(re)
        for i in range(9):
            quotient=quotient/1000
            rem=quotient%1000
            if(rem!=0):
                list4.append(rem)
        for k in reversed(list4):
            list3.append(k)
        j=j+1
    #print list3
    strin=''
    try:
        for i in list3:
            strin=strin+str(chr(i))
    except ValueError:
        strin="Oops!  Sorry Hacker.Better Luck next time"     
    root = Tk()
    text = Text(root)
    text.insert(INSERT, "PlainText:")
    text.insert(END,strin)
    text.pack()
    root.mainloop()
    time.sleep(15)
    s.close()

if(status==2):
    s.sendall('false')
    time.sleep(15)
    s.close()
