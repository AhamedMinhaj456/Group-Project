   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	   =#clr-namespace:GUI_Project.ViewModelGUI_Project.ViewModel  5   	       GUI_Project.Log_In   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	   2VM#clr-namespace:GUI_Project.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency$
 True��6R    � Title$ Log_In��5	   	   $	��550��6   $	��800��6%   .��5      �  � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��1.5* �6#   .+�5      ��  �� CornerRadius$ 	10 0 0 10��6   ��5      �� 5       �� 
StartPoint$	 0 0&�6*    �� EndPoint$	 1 1&�6;   .��5      � 	 � Color$	 #3AA9AD��6'   
 � Offset$
 0Q�67   � 5      $	 #3AADA1��6'   $
 1Q�67   5      ._�5      � .+�5       �� .+�5!      �  � Points �    -1��� ;X�����#4EB1E66>   � 5"      ' �    �� �� ���� ��
�����#4EB1E66C   A� 5#      $��250 450 0 0q�6"   $��40��67   $��40��6B   ���#4EB1E66N   A� 5$      $��
50 400 0 0q�6"   $��20��66   $��20��6A   ���#4EB1E66M   5%      �� 5&      $��Center=�6!   .+�5'      �� $��Log in as Staff��6$   $��20(�6;      	TitleText#��[  6I   �� 5(      $F��@Connect With Us 
Enter your personal info and create new Account��6$     
normalText#��[ 6q    J� Opacity$	 0.8Q�6�   $��20 30q�6�   �� 5)      -   5        $��	Main Menu��5)   !    
 Button#��[ 6G   5*      5+      5,      �� 5/      -   5        ���#FFFFFF$��1��5/   *   $ 	0 10 10 0��6:   ._�50      �� .+�51      �� -   5        $��/image/close.png��51   8   $��15��6S   $��0 4 5 0q�6^     iconApp#��[ 6o   �� 52      -   5        $��/image/Maximise.png��52   :   $��15��6W   $��0 0 5 0q�6b   #��[ 6s   �� 53      -   5        $��/image/minimise.png��53   :   $��15��6W   $��0 0 5 0q�6b   #��[ 6t   �� 54      $��
0 -20 0 40q�6    $��Log in as Admin��64   #��[  6K   ���#3AB1986n   �� 56      $��1q�6   ���#abc0af$
��70 7q�6G   $ 5��6U   ._�57      � $	��7 9q�6    58      �� 59   "   $
��auto �63   �� 5:   "   $��* �63   .+�5?      �� $��/image/Email.png��6$   $��20��6>   $��20��6I   �� 5@      -   5         ��Name$ 	textEmail��5@   )   $��
Admin Name��6\     textHint#��[ 6n   �� 5A      -   5         ��Name$ txtAdminLoginName��5A   @    � Cursor$ IBeam��6~     textBox#��[ 6�   ��6&   �� *
TxtEmail+6�   5B      5C      �� 5E      $��1q�6   ���#abc0af$
��70 7q�6G   $ 5��6U   ._�5F      � $	��7 9q�6    5G      �� 5H   "   $
��auto �63   �� 5I   "   $��* �63   .+�5L      �� $��/image/Lock.png��6$   $��20��6=   $��20��6H   �� 5M      -   5        $ textPassword��5M   )   $��Password��6b   #��[ 6r   G� 5N      -	   5         G�Name$ txtAdminLoginPassword��5O   !   $ IBeam��6n   #��[ 6}   &    GUI_Project.PasswordBoxAssistant   BindPassword 5N   *   �� *adminPassword+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5O   }   5P      5Q      �� 5S      -
   5        $��Admin Log In��5S        
mainButton#��[ 65   6Y   �� 5W      $)��#Connect with us using Social media ��6!   #��[ 6L   ���#878787$��	0 30 0 15q�6�   �� 5Y       �� Orientation$ 
Horizontal=�6!   $	��0 0q�6:   $��Center=�6G   .+�5[      ��   ButtonCircle#��[ 6!   .��5]      �� $��/image/Google.png��6%   $��20��6@   $��20��6K   5^      �� 5_      #��[ 6!   .��5`      �� $��/image/Facebook.png��6$   $��20��6A   $��20��6M   5a      �� 5b      #��[ 6!   .��5c      �� $��/image/Linked In.png��6%   $��20��6C   $��20��6N   5d      5e      5g      5h      5j      �� 5l   
   $��1��6   $��0 2 0 0q�6   ���#E2E9E9$ 0 0 5 5 ��6N    �� Padding$ 0q�6f   
�������._�5m      � .+�5o      �� $,��&Copyright © 2023 . All Right Reserved��6   $
��15 0q�6I   $
��Left=�6W   $��Center=�6r   $��13(�6�   ���#9090985p      �� 5s      $ 
Horizontal=�6   $��10 0 0 0q�66   $��Center=�6I   $��Right=�6d   .+�5t      �� -   5        $
��Home��5t        bottomButton#��[ 69   �� 5u      -   5        $��Features��5u      #��[ 6A   �� 5v      -   5        $��Services��5v      #��[ 6A   �� 5w      -   5        $��	 About Us��5w      #��[ 6A   �� 5x      -   5        $��Developed By��5x      #��[ 6I   ���#FF131E6o   5y      5z      5{      5|      5}      