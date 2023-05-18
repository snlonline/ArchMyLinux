sudo nano /etc/pacman.conf (uncomment "Color", "ParallelDownloads" also setting it == 15 & add ILoveCandy)

git clone https://github.com/snlonline/ArchMyLinux.git

cd ArchMyLinux/

sudo pacman -S --needed -< paclist.txt

sudo systemctl enable sddm.service

reboot

sudo pacman -Rdd discover

reboot

sudo systemctl enable NetworkManager

sudo systemctl start NetworkManager

sudo systemctl enable bluetooth.service

sudo systemctl start bluetooth.service

sudo systemctl enable ufw

sudo systemctl start ufw

git clone https://aur.archlinux.org/paru.git

cd paru

makepkg -si

sudo nano /etc/paru.conf (uncomment "BottomUp")


