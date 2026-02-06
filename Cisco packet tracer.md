
```
//switch
Vlan 2  
name OFFICE  
vlan 3  
name MANAGER  
vlan 4  
name Servers  
vlan 100  
name SSH  

...... do sh vlan br  

int fa0/1  
sw m ac  
sw tr all vlan 2-4,100  
des TRUNK  
ex  
int range fa0/2-3  
sw m ac  
sw ac vlan 2  
des OFFICE  
ex  
int range fa0/4-5  
sw m ac  
sw ac vlan 3  
des MANAGER  
ex  
int range fa0/6-7  
sw m ac  
sw ac vlan 4  
des Servers  
ex  
int vlan 100  
ip address 192.168.100.100 255.255.255.0  
des SSH  
ex  
ip def 192.168.100.1  

...... do sh run  

int g10/0  
no sh  
ex  
int g10/0.2  
en d 2  
ip add 192.168.20.1 255.255.255.0  
des OFFICE  
ex  
int g10/0.3  
en d 2  
ip add 192.168.30.1 255.255.255.0  
des MANAGER  
ex  
int g10/0.4  
en d 4  
ip add 192.168.40.1 255.255.255.0  
des Servers  
ex  
int g10/0.100  
ec d 10  
ip add 192.168.100.1 255.255.255.0  
des SSH  
ex  
```

```
ip dhcp pool vlan4
network 192.168.104.0 255.255.255.0
default-router 192.168.104.1
dns-server 8.8.8.8
exit
```

```
en
conf t

hostname RxC HQ-R

no ip domain-lookup V

int gi0/0V
no sh
des int for network left
ip address 192.168.100.1 255.255.255.0
exit

int gi0/1
no sh
des int for network right
ip address 192.168.200.1 255.255.255.0
exit

--- Switch left

en
conf t

hostname SW-L

no ip domain-lookup

int vlan 1
no sh
des int for network left
ip address 192.168.100.100 255.255.255.0
exit

ip def 192.168.100.1

--- Switch right

en
conf t

hostname SW-R

no ip domain-lookup

int vlan 1
no sh
des int for network right
ip address 192.168.200.100 255.255.255.0
exit

ip def 192.168.200.1
```

```
telnet – технология для удаленного подключения к сетевому оборудованию  
cisco без использования шифрования  

---после настройки ip адресов---

username admin privilege 15 secret cisco  
enable secret cisco  

line vty 0 15  
login local  
password cisco  
transport input telnet  
transport output telnet  
exec-timeout 0 0  
exit  

проверка:  
telnet <ip адрес, к кому хотите подключиться и где испроен telnet>  
telnet 192.168.20.100
```