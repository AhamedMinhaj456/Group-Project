   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GUI_Project.ViewModelGUI_Project.ViewModel  5   	       GUI_Project.Admin_Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   .VM#clr-namespace:GUI_Project.ViewModel   5   	     � Title$  Admin_Login��5      $	��500��6.   $	��800��6;   
������  � 
ResizeMode$ CanMinimize=�5	   "    � AllowsTransparency$
 True��6;    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5        $��0 0 0 2q�5      ���#E2E9E9 �� CornerRadius$ 5 5 0 0 ��6A   
������� �� Padding$ 10q�6l   ._�5      � .+�5      ��   	topButton#��[ 6   $
��Left=�6<   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial  	   Kind$
	 Menu=�6,     topButtonIcon#��[ 68   5        5       $	 	Microsoft=�6(   $��22��69   $��22��6D   $��Center=�6P   $��Center=�5!   (   
���  ��6C   �� 5#      #��[ 6   $��right=�6<   .��5$        $	 Magnify=�6,   #��[ 6;   5%      5&      5'      � 5+   
   $��1��6   ��5,      �� 5-      
 �� Color$
 
WhiteSmoke��6"   .+�50      � ��51      �� 52       �� ImageSource$ /image/Background.jpg��6!    �� Opacity$	 0.7Q�6E   54      �� 56       � Cursor$
 Hand��6   .+�57      �� -   5        $��/image/close.png��57   4   $��15��6O   $��0 4 5 0q�6Z     iconApp#��[ 6k   �� 58      -   5        $��/image/Maximise.png��58   6   $��15��6S   $��0 0 5 0q�6^   #��[ 6o   �� 59      -   5        $��/image/minimise.png��59   6   $��15��6S   $��0 0 5 0q�6^   #��[ 6p   5:      �� 5<      $	��300��6   $��Center=�6!   $��Center=�6<   ���#E2E9E9$��2q�5=      $ 10��6)   $ 30q�6;   
�������._�5>      �� .+�5?      �� $��Log in as Staff��6    ���#5A5A5A$��16(�6L   $��SemiBold"�6Z   $��0 0 0 10q�6p   � 5A      .+�5B      �� $��Enter Email��6%   $��35 0 5 0q�68   $��Center=�6J   ���#bdbdbd K� ZIndex$ 1��5C   9    J� IsHitTestVisible$ False��6J   ��5B   f   �� *
textHint+y�5D   $   ��  �� ElementName$ emailTxt�� �� Path$ Text.IsEmpty� �� 	Converter# [  �� 5G      -   5         ��Name$ txtuserLoginName��5G   #     TextBox#��[ 6=   $ IBeam��6^   $��30 9 0 9q�6m   6�     5I      $	 EmailVariant=�60   $��15��6D   $��5 0 0 0q�6O   ���#c7c7c7$��Center=�6u   5J      � 5L      .+�5M      �� $��Enter Password��6$   $��35 0 5 0q�6:   $��Center=�6L   ���#bdbdbd$ 1��5N   9   $ False��6J   ��6c   �� *
textHint+y�5O   $   �� $ passwordTxt��$ Password.IsEmpty�# [  G� 5T      -   5         G�Name$ txtUserLoginPassword��5T   &     passwordBox#��[ 6D   $ IBeam��6i     5V      $	 LockOutline=�60   $��15��6C   $��5 0 0 0q�6N   ���#c7c7c7$��Center=�6t   5X      �� 5Y      $��Remember Me��6    $��	 0 10 0 5q�66    d� 	IsChecked$
 TrueY�6I   � 5\      $
��0 10q�6    � ColumnDefinitions 5]      �� 5^      $��* �6/   �� 5_      $��* �6/   .+�5b      �� -   5        $��Sign In��5b   !     mainButtonLong#��[ 6O   $��0 0 5 0q�6w   ���#FF131F6�   �� 5c      -   5        $��Create Account��5c   !   #��[ 6Q   $��12,0,6,0q�6y   $��1��6�   
������ 
���   �$��35��6�   $	��Top=�6�   5d      � 5g      $
��0 10q�6    5h      �� 5i      $��* �6/   �� 5j      $
��auto �6/   �� 5k      $��* �6/   .+�5n      �� ���#DFDFDF6$   �� 5o      $��Or��6$   ���#5a5a5a$��1��6C   $��5 0 5 2q�6S   �� 5p      ���#DFDFDF$��2��69   5r      �� 5u      -	   5        $��Log In as Admin��5u      #��[ 6L   $��5 0 0 0q�6t   
���   �$��16(�5v   0   $	��161��6>   $��37��6J   5y      5{      5|      �� 5   
   $��2��6   $��0 2 0 0q�6   ���#E2E9E9$ 0 0 5 5 ��6N   $ 10q�6f   
�������._�5�      � .+�5�      �� $,��&Copyright © 2023 . All Right Reserved��6   $
��15 0q�6I   $
��Left=�6W   $��Center=�6r   $��13(�6�   ���#9090985�      �� 5�       �� Orientation$ 
Horizontal=�6   $��10 0 0 0q�66   $��Center=�6I   $��Right=�6d   .+�5�      �� -
   5        $
��Home��5�        bottomButton#��[ 69   �� 5�      -   5        $��Features��5�      #��[ 6A   �� 5�      -   5        $��Services��5�      #��[ 6A   �� 5�      -   5        $��	 About Us��5�      #��[ 6A   �� 5�      -   5        $��Developed By��5�      #��[ 6I   ���#FF131E6o   5�      5�      5�      5�      5�      