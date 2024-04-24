import socket

# IP e porta para receber os pacotes de relatório JSON enviados

UDP_IP = "10.14.58.131"
UDP_PORT = 11666

sock = socket.socket(socket.AF_INET, # Internet
                     socket.SOCK_DGRAM) # UDP
sock.bind((UDP_IP, UDP_PORT))

while True:
    data, addr = sock.recvfrom(1024) # buffer size is 1024 bytes
    print("received message: %s" % data)