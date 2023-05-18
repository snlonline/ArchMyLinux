git clone https://github.com/snlonline/ArchMyLinux.git
cd ArchMyLinux/
sudo pacman -S --needed -< paclist.txt
sudo systemctl enable bluetooth.service
sudo systemctl start bluetooth.service
sudo systemctl enable sddm.service
reboot