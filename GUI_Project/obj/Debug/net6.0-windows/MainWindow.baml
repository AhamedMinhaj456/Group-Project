   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	       GUI_Project.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	     � WindowStyle$
  None=�5       � 
ResizeMode$ CanMinimize=�6-   
���   � � AllowsTransparency$
 True��6Y    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��480��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��* �6   .+�5      � ��5      �� 5       �� ImageSource$ /image/hospital.png��6!    �� Opacity$	 0.7Q�6C   5      �� 5      $��20q�6   ���	#FFC71585._�5      ��  �� Orientation$ Vertical=�6   $��
200 0 0 0 q�65   .+�5      �� -   5        $��/image/close.png��5   8   $��15��6S   $��0 4 5 0q�6^      iconApp#��[  6o   �� 5      -   5        $��/image/Maximise.png��5   :   $��15��6W   $��0 0 5 0q�6b   #��[  6s   �� 5      -   5        $��/image/minimise.png��5   :   $��15��6W   $��0 0 5 0q�6b   #��[  6t   �� 5      	 J� Opacity$	 1Q�6    $��	80 00 0 0q�6,   $6��0Welcome To Patient 
         Registration System��6?   $��35(�5      $
��Bold"�6&   
��� ���68   �� 5"      -   5        $��Welcome��5"      
�������
���  ��$
��Bold"�5#        button1#��[ 6+   $��
10 100 0 0q�6a   �� 5&      -   5        $
��Exit��5&      ���	#FF48D1CC
���  ��$
��Bold"�5'      #��[ 6+   $��	10 00 0 0q�6c   5,      5-      �� 5/      $ 
Horizontal=�6   $	��250��62   $
��Left=�6>   $		 0.5Q�50      ���	#FF00FF0752      �� 56   
   $��1��6   $��0 2 0 0q�6   ���#E2E9E9
 �� CornerRadius$
 0 0 5 5 ��6N    �� Padding$ 0q�6g   
�������._�57      � .+�59      �� $,��&Copyright © 2023 . All Right Reserved��6   $
��15 0q�6I   $
��Left=�6W   $��Center=�6r   $��13(�6�   ���#9090985:      �� 5=      $ 
Horizontal=�6   $��10 0 0 0q�66   $��Center=�6I   $��Right=�6d   .+�5>      �� -   5        $
��Home��5>        bottomButton#��[ 69   �� 5?      -   5        $��Features��5?      #��[ 6A   �� 5@      -   5        $��Services��5@      #��[ 6A   �� 5A      -	   5        $��	 About Us��5A      #��[ 6A   �� 5B      -
   5        $��Developed By��5B      #��[ 6I   ���#FF131E6o   5C      5D      5E      5G      5H      