   M S B A M L   `   `   `  ����C  ?BaiTap95, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BaiTap95BaiTap95  5   	       BaiTap95.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BaiTap95     5   	     � Title$  Chọn đồ uống��5   	   $	��500��6   $	��600��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��3��6   $��5��6%   $��
15,10,15,0q�66   
����  �$��2q�6]   ._�5      �� -   5         ��Name$ lstDrink��5      $��0��6(   $��3��65   $��5��6I   .@�5      �� 
�������.��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ 
chkNuocCam��5   #      checkBoxStyle#��[  67   6`   �� 5        
imageStyle#��[ 6    $��/orangejuice.jpg��6D   �� 5      $��Center=�6$   $��16(�6?   $��15,0,0,0q�6M   Nước cam tươi6n   5      5      �� 5       .��5!      �� $ 
Horizontal=�6!   .+�5"      �� -   5        $ 	chkKiWiEp��5"   #   #��[  66   6_   �� 5#      #��[ 6    $��/kiwijuice.jpg��6D   �� 5$      $��Center=�6$   $��16(�6?   $��15,0,0,0q�6M   Nước Kiwi ép6m   5%      5&      �� 5'      
�������.��5(      �� $ 
Horizontal=�6!   .+�5)      �� -   5        $ 	chkXoaiEp��5)   #   #��[  66   6_   �� 5*      #��[ 6    $��/mangojuice.jpg��6D   �� 5+      $��Center=�6$   $��16(�6?   $��15,0,0,0q�6M   Nước xoài ép6m   5,      5-      �� 5.      .��5/      �� $ 
Horizontal=�6!   .+�50      �� -   5        $ 
chkSuaTuoi��50   #   #��[  67   6`   �� 51      #��[ 6    $��	/milk.png��6D   �� 52      $��Center=�6$   $��16(�6?   $��15,0,0,0q�6M   Sữa tươi tiệt trùng6t   53      54      �� 55      
�������.��56      �� $ 
Horizontal=�6!   .+�57      �� -   5        $ chkCaPhe��57   #   #��[  65   6^   �� 58      #��[ 6    $��/cafe-espresso.jpg��6D   �� 59      $��Center=�6$   $��16(�6?   $��15,0,0,0q�6M   Cà phê Espresso6p   5:      5;      5<      5=      �� 5>   
   $��5��6   $��0��6"   $��3��62   $��10q�6F   $ 
Horizontal=�6R   $��Center=�6k   $��Center=�6�   .+�5?      �� -   5        $��Gọi đồ uống��5?      $��14(�6+     buttonStyle#��[ 69   6x   5@      5A      5B      