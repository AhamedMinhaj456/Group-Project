   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	   =#clr-namespace:GUI_Project.ViewModelGUI_Project.ViewModel  5   	   ]3clr-namespace:GUI_Project.Registration_User_Control%GUI_Project.Registration_User_Control  5   	   "    GUI_Project.View.CreateAdmin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	   2VM#clr-namespace:GUI_Project.ViewModel     5   	   Buc3clr-namespace:GUI_Project.Registration_User_Control     5   	   -   5          � Title$  CraeteAdmin��5
   	   $	��550��6   $	��350��6*    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanMinimize=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � DataContext 5      )   #GUI_Project.ViewModel.CreateAdminVM  5   
   .��5      ��  �� CornerRadius$ 12��6   ._�5   
   �� $ 10��6   $��2q�5       J� Opacity$	 0.7Q�5      ��5       �� 5!       �� 
StartPoint$	 0 0&�6&   	 �� EndPoint$		 1,1&�67   .��5"      � 
 � Color$
 #462AD8��6#    � Offset$ 0Q�63   � 5#      $
 #DA34AE��6#   $
 0.75Q�63   � 5$      $
 #8a16c1��6#   $ 1Q�63   5%      ��5(      �� 5)      $	 0 1&�6&   $		 1,0&�67   .��5+      � $
 	#FF000080��6#   $ 0Q�65   � 5,      $
 #FF00��6#   $ 1Q�61   5-      ._�50      �  � RowDefinitions 51      �� 52      $��80 �6$   �� 53      .+�55      � $��0��6    � ColumnDefinitions 57      �� 59      $	��350 �6+   �� 5:      $��25 �6+   �� 5;      $��5 �6+   .+�5>      ��  � Cursor$
 Hand��6!   .+�5?      �� -   5        $��/image/close.png��5?   <   $��15��6W   $��0 4 5 0q�6b      iconApp#��[  6s   �� 5@      -   5        $��/image/Maximise.png��5@   >   $��15��6[   $��0 0 5 0q�6f   #��[  6w   �� 5A      -   5        $��/image/minimise.png��5A   >   $��15��6[   $��0 0 5 0q�6f   #��[  6x   5B      5�      �� 5�      $	��220��6   $��1��5�       �� Orientation$ Vertical=�5�      $��0,15,0,0q�5�      .+�5�      �� $��Create Admin��6!   $��0 0 0 0 q�5�   !   
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $.��(----------------------------------------��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       �� 5�      $��
Admin Name��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtAdminName��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��30,0,0,0q�5�      .��6T   ��5�      �� 5�       �� ImageSource$ /Image/user-icon.png��6)    j� Stretch$ Uniform=�5�   )    j� 
AlignmentX$
 Left=�5�   )   .��5�   .   5�      �� 5�      $��Password��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       G� 5�      -   5         G�Name$ txtAdminPassword��5�   "   $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� G� 
CaretBrush
 �����
�������$��0,0,0,2q�5�      $��28��5�      $��Bottom=�5�      $��0,5,0,0q�5�      $��30,0,0,0q�5�      ��5�      �� 5�      $ /Image/key-icon.png��6)   $ Uniform=�5�   )   $
 Left=�5�   )   5�      �� 5�      -   5         ��Name$ btnLogin��5�      $��0q�5�      $��Create Admin��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,20,0,0q�5�      ��5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � �� �� Value �#462AD86?    �� Triggers 5�   "   P� 5�   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�       �� 
TargetType" ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,25,0,0q�5�   !   .+�5      �� $��Already have an Account?��6$   $��0 8 0 0q�5     
�������$��12(�5      $��Medium"�5      $��
Montserrat)�5      �� 5     -   5        $��	Main Menu��5  !   
�������$��12(�5      $��Medium"�5	      $��
Montserrat)�5
      $
 Hand��5      $��8,0,0,0q�5        bottomButton#��[ 5  !   5     5     5     5     5     5     