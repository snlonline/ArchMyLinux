git clone https://github.com/snlonline/ArchMyLinux.git

cd ArchMyLinux/

sudo pacman -S --needed -< paclist.txt

sudo systemctl enable sddm.service

reboot

sudo systemctl start NetworkManager

sudo systemctl start bluetooth.service
