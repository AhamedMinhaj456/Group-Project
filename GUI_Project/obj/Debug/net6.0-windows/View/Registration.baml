   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	   =#clr-namespace:GUI_Project.ViewModelGUI_Project.ViewModel  5   	   ]3clr-namespace:GUI_Project.Registration_User_Control%GUI_Project.Registration_User_Control  5	   	       GUI_Project.Registration   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	   2VM#clr-namespace:GUI_Project.ViewModel     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   <uc3clr-namespace:GUI_Project.Registration_User_Control  5	   	   -   5          � WindowStyle$
  None=�5
       � AllowsTransparency$ False��6-    � WindowStartupLocation$ CenterScreen=�5   	   
������  � Title$ Registration��5   	   $	��700��6   $
��1000��6+   .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��350 �6#   �� 5      $��* �6#   .+�5      �� ���#ffd500 �� Padding$ 30q�6*   ._�5      �� $��Center=�6   .+�5      �� $��/image/6.png��6   $	��160��62   $	��160��6>   $��0 0 0 40q�6K   �� 5       $��Let's Start With Us��6     �� TextAlignment$ Center=�6;   $��SemiBold"�6R   ���#363636$��28(�5!   1   �� 5"      $A��;It should only take couple of minutes to hospitality to you��6    $
��Wrap=�5#      $��16(�60   $ Center=�6>   ���#363636$��	0 20 0 20q�6j   �� 5&         ButtonBlack#��[  6   .��5'      "  FontAwesome.WPF.ImageAwesome     Icon$ 
AngleRight=�6*   $��25��6<   $��25��6G   	   
Foreground	 �#ffd500$��3 0 0 0q�6h   5(      5)      5*      �� 5-      -   5        $��1��5-      $ 20q�6%   ���#FFFFFF._�5.      � .+�5/      �� -   5        $��/image/close.png��5/   8   $��15��6S   $��0 4 5 0q�6^     iconApp#��[ 6o   �� 50      -   5        $��/image/Maximise.png��50   :   $��15��6W   $��0 25 5 0q�6b   #��[ 6t   �� 51      -   5        $��/image/minimise.png��51   :   $��15��6W   $��0 50 5 0q�6b   #��[ 6u   � 54      $��Center=�6   $��Center=�68   $��0 10 0 0q�6S    55      �� 56      $	��150 �6/   �� 57      $��* �6/    5:      �� 5;      $
��auto �6,   �� 5<      $
��auto �6,   �� 5=      $
��auto �6,   �� 5>      $
��auto �6,   �� 5?      $
��auto �6,   �� 5@      $
��auto �6,   �� 5A      $
��auto �6,   �� 5B      $
��auto �6,   .+�5E      �� $��0��6$   $
��Name��62     Text#��[ 6>   �� 5F      $��1��6$   $��Address��61   #��[ 6@   �� 5G      $��2��6$   $��Gender��61   #��[ 6?   �� 5H      $��3��6$   $��Date Of Birth��61   #��[ 6F   �� 5I      $��4��6$   $��Email��61   #��[ 6>   �� 5J      $��5��6$   $��Mobile��61   #��[ 6?   �� 5K      $��6��6$   $��
Membership��61   #��[ 6C   7   1GUI_Project.Registration_User_Control.My_Text_Box  5N      $��1��6*   $��0��6:   
   Hint$

 Jhon��6H   .��5O      �� ��6&   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5P        5Q      -   5          Name$ 
txtAddress��5Q   )   $��1��6=   $��1��6M   $
 Charles��6Z   .��5R      �� ��6&   �� *	Address+$ PropertyChanged=�5S      (  "System.Windows.Controls.DatePicker  5V      -   5          Name$ 
datePicker��5V   B   $��1��6%   $��3��65   $
��Left=�6�   $��28��6�   $	��Top=�6�   $	��159��6�   $��14.667(�6�     5[      -   5        $ txtEmail��5[   )   $��1��6;   $��4��6K   $
 JhonCharles@net.com��6X   .��5\      �� ��6&   �� *Email+$ PropertyChanged=�5]        5^      -	   5        $ 	txtMobile��5^   )   $��1��6<   $��5��6L   $
 +94-07xxxxxxxx��6Y   .��5_      �� ��6&   �� *Mobile+$ PropertyChanged=�5`      �� 5b      -
   5         ��Name$ 	txtGender��5b   %    �� Orientation$ 
Horizontal=�69   $��1��6R   $��2��6b   $
��0 10q�6o   .+�5c      	� -   5        $
��50 0q�5c   *    	� 	GroupName$ GenderGroup��68   $
��Male��6P    d� 	IsChecked$
 TrueY�6_   6p   	� 5d      -   5        $
��50 0q�5d   *   $ GenderGroup��68   $��Female��6P   6a   5h      �� 5i      -   5        $ txtMembership��5i   %   $ 
Horizontal=�6<   $��1��6V   $��6��6f   $
��0 10q�6s   .+�5k      	� -   5        $
��20 0q�5k   *   $ GenderGroup��68   $
��Male��6P   $
 TrueY�6_   6p   	� 5l      -   5        $
��20 0q�5l   *   $ GenderGroup��68   $��Female��6P   6a   	� 5m      -   5        $
��20 0q�5m   *   $ GenderGroup��68   $��Female��6P   6a   5r      � 5t      $��1��6   $��7��6/   $��0 40 0 0q�6<    5u      �� 5v   "   $��* �63   �� 5w   "   $��* �63   .+�5{      �� -   5        $��	Main menu��5{   %   $��0 0 10 0q�6K     
ButtonMain#��[ 6]   �� 5|      -   5        $
��Next��5|   %   $��10 0 0 0q�6K   $��1��6]     buttonMainGreen#��[ 6m   5}      5~      5      5�      5�      �� 5�   
   $��1��6   $��0 2 0 0q�6   ���#E2E9E9 �� CornerRadius$ 0 0 5 5 ��6N   $ 0q�6f   
�������._�5�      � .+�5�      �� $,��&Copyright © 2023 . All Right Reserved��6   $
��15 0q�6I   $
��Left=�6W   $��Center=�6r   $��13(�6�   ���#9090985�      �� 5�      $ 
Horizontal=�6   $��Center=�66   $��Right=�6Q   .+�5�      �� -   5        $
��Home��5�        bottomButton#��[ 6@   �� 5�      $��Features��6   #��[ 60   �� 5�      $��	Solutions��6   #��[ 61   �� 5�      $��Videos��6   #��[ 6.   �� 5�      $��	 About Us��6   #��[ 61   �� 5�      $��Log In��6   #��[ 6.   ���#FF131E6T   5�      5�      5�      5�      5�      