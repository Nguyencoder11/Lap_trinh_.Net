   M S B A M L   `   `   `  ����B  >Bai10.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Bai10._1Bai10._1  5   	       Bai10._1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Bai10._1     5   	     � Title$  Quản lý sinh viên��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5	      � .+�5
   
   o� -   5        $��mainmenu��5
      $��20��6   $	��Top=�6+   .@�5      m� -   5        $��menu1��5   )   $��Hệ thống��6   68   m� 5      -   5        $��menu2��5   *   $��Chức năng��6   69   m� 5      -   5        $��menu3��5   '   $��
Hỗ trợ��6   66   5      c� 5   
   -   5        $��maintoolbar��5      $��30��6   $	��Top=�61   $��0, 20, 0, 0q�6I   .@�5      �� -   5        $��btnNhapSinhVien��5      .��5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   .+�5      �� $��/students.png��6      
imageStyle#��[  63   6Y   �� 5      
Sinh viên6+   5      5      �� 5      -   5        $��btnNhapKhoa��5      .��5      �� $ 
Horizontal=�6   $
��Left=�66   .+�5      �� $��	/khoa.png��6   #��[  6/   �� 5      Khoa6&   5      5      �� 5      -   5        $��btnNhapMonHoc��5      .��5      �� $ 
Horizontal=�6   $
��Left=�66   .+�5      �� $��/subject.png��6   #��[  62   6X   �� 5      
Môn học6)   5       5!      �� 5"      -	   5        $��btnNhapDiem��5"      .��5#      �� $ 
Horizontal=�6   $
��Left=�66   .+�5$      �� $��	/mark.png��6   #��[  6/   6U   �� 5%      Nhập điểm6+   5&      5'      �� 5(      6   �� 5)      -
   5        $��btnTraCuuDiem��5)      .��5*      �� $ 
Horizontal=�6   $
��Left=�66   .+�5+      �� $��/viewmark.png��6   #��[  63   6Y   �� 5,      Xem điểm6*   5-      5.      �� 5/      -   5        $��btnTraCuuSvTheoKhoa��5/      .��50      �� $ 
Horizontal=�6   $
��Left=�66   .+�51      �� $��/thongke.png��6   #��[  62   6X   �� 52      Thống kê Khoa6/   53      54      �� 55      -   5        $��btnThoat��55      $��30,0,0,0q�6<   .��56      �� $ 
Horizontal=�6   $
��Left=�66   .+�57      �� $��	/quit.png��6   #��[  6/   6U   �� 58      Thoát6'   59      5:      5;      5<      5=      