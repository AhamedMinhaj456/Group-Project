   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	   =#clr-namespace:GUI_Project.ViewModelGUI_Project.ViewModel  5   	       GUI_Project.Admin_Control   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	   2VM#clr-namespace:GUI_Project.ViewModel     5   	     � Title$  Admin_Control��5	   	    � WindowStyle$
 None=�6     � AllowsTransparency$ False��63    � WindowStartupLocation$ CenterScreen=�5
   	   
������ $	��700��5   	   $
��1000��6   .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��180 �6#   �� 5      $��* �6#   .+�5      �� ���	#FF00008B._�5      �� -   5         ��Name$ dropdownInnerContent��5   _   $	��200��6   $	��Top=�6*   $��Center=�6B   $	��400��5       � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value N� EnterActions �� TargetProperty	 �� To g� Duration N� ExitActions��%R  '��       '�� !     �� 5       " ��6    5"      �� 5#      " ��6    .�5$      �� 	 �@��Padding$
 20 10q�68   �� 5%      	 � ��

 ���� 6;    5&      P� 5'   "    �@J�IsMouseOver$
 True��6A    5(   &   �� 5)   *   .��5*   .   �� .��5+   2   �� $( "Background.(SolidColorBrush.Color)�5,   5   	 White5-   5   $ 0:0:0.2D�5.   5   5/   /   50   +    52   &   �� 53   *   .��54   .   �� .��55   2   �� $( "Background.(SolidColorBrush.Color)�56   5    Transparent57   5   $ 0:0:0.2D�58   5   59   /   5:   +   5<   #   5>      5?      .+�5B      �� ._�5C      �� -   5        $��Create Admin��5C   !   
������ $
��Left=�5E   !   $��16(�5F   !   $
��Bold"�6/   $��0q�5H   !   5J      �� 5L      ._�5M      �� -   5        $��Create User��5M   "   
������ $
��Left=�5O   !   $��16(�5P   "   $
��Bold"�60   $��0q�5R   !   5U      �� 5W      
������ ._�5X      �� -   5        $��back to Admin Page��5X   !   
������ $��16(�5Z   !   $
��Bold"�6/   $
��Left=�5[   !   $��0q�5]   !   5_      �� 5a      ._�5b      �� -   5        $��Log Out��5b   !   
������ $
��Left=�5d   !   $��16(�5e   !   $
��Bold"�6/   $��0q�5g   !   5i      5k      5l      �� 5m      $��1��6   
�������._�5n      ��  � Cursor$
 Hand��6   .+�5o      �� -   5        $��/image/close.png��5o   8   $��15��6S   $��0 4 5 0q�6^      iconApp#��[  6o   �� 5p      -   5        $��/image/Maximise.png��5p   :   $��15��6W   $��0 0 5 0q�6b   #��[  6s   �� 5q      -   5        $��/image/minimise.png��5q   :   $��15��6W   $��0 0 5 0q�6b   #��[  6t   �� 5s      $(��"Admin User Password Access Details��6    $��
100,1,0,20q�6J   &   System.Windows.Controls.DataGrid  5t      -	   5          Name$ dataGridAdmin��5t         AutoGenerateColumns$
 True��66   $
��Left=�6Q   $	��204��6l   $��	100,1,0,0q�6y   $	��Top=�6�   $	��400��6�   �� 5u      $)��#Staff User  Password Access Details��6    $��100,40,0,20q�6K     5v      -
   5        $ dataGridUser��5v      $
 True��65   $
��Left=�6P   $	��204��6k   $��	100,1,0,0q�6x   $	��Top=�6�   $	��400��6�   5y      5z      5{      �� 5   
   $��1��6   $��0 2 0 0q�6   ���#E2E9E9 �� CornerRadius$ 0 0 5 5 ��6N    �� Padding$ 0q�6f   
�������._�5�      � .+�5�      �� $,��&Copyright © 2023 . All Right Reserved��6   $
��15 0q�6I   $
��Left=�6W   $��Center=�6r   $��13(�6�   ���#9090985�      �� 5�       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��Right=�6Q   .+�5�      �� -   5        $
��Home��5�        bottomButton#��[ 69   �� 5�      $��Features��6   #��[ 60   �� 5�      $��	Solutions��6   #��[ 61   �� 5�      $��Videos��6   #��[ 6.   �� 5�      $��	 About Us��6   #��[ 61   �� 5�      $��Log In��6   #��[ 6.   ���#FF131E6T   5�      5�      5�      5�      5�      