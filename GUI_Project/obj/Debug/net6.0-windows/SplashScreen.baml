   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GUI_ProjectGUI_Project  5   	       GUI_Project.SplashScreen   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GUI_Project     5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  SplashScreen��5	   	   $	��800��6   $	��800��6+    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6   
���   �$��25q�5      .��5   
   �  � ColumnDefinitions 5      �� 5      $	��650 �6#   61   �� 5      $	��400 �6#   61   .+�5      �� $��0��6   $
��Left=�6)   $��Center=�5      $��50,0,0,0q�64   $	��673��6F   $	��590��6S   .+�5      �� .+�5      �  � Points' �    e� �� '�) �� F�# �����	#FF7400BA$
��Left=�6P    �� Left$ 23��6k   $	��Top=�6|   
 �� Top$
 -246��6�   � 5      ' �    �� �� F�# �� e� F�#���	#FF62039B$
��Left=�6P   $
 -246��6k   $	��Top=�6}   $	 150��6�   � 5       ' �    �� �� �� �� �� �����	#809A24F9$
��Left=�6P   $	��Top=�6k   $	��300��6�   $	 150��6�   $
 -341��6�   � 5"      ' �    F�# �� �/ �� '�) ��$
��Left=�6@   $
 -246��6[   $	��Top=�6m   ���	#FF7009CF$ 50��6�   $	��743��6�   � 5$      ' �    �� �� e� �� �� e����	#80490B51$	 140��6P   $	 -46��6b   $
��Left=�6s   $	��Top=�6�   � 5&      ' �    '�) �� �5 �� �/ F�#���	#8049055E$ 10��6P   $
 -246��6a   $
��Left=�6s   $	��Top=�6�   $	��868��6�   $	��555��6�   � 5(      ' �    �� �� F�# �� e� �����	#80451656$
 -200��6P   $
��Left=�6b   $	��Top=�6}   � 5*      ' �    e� �� '�) �� F�# F�#���	#80662EA3$	 150��6P   $
��Left=�6b   $	��Top=�6}   $	 -36��6�   5+      � 5,      .+�5-      �� $��0 60 0 5q�6   $	��100��60   5/      �� 50      $"��Patient Registration System ��6    $��35(�6D   $��	ExtraBold"�6R   
��� ���$	��564��6{   $
��Left=�51       $��Center=�6;   52      �� 53      $��Loading Resources.....��6   $��16(�6:   $��Heavy"�6H   
�������$
��Left=�54      $��	0 30 0 15q�67   6L   �� 57      $"��MORAIS M.N.S. 
 EG/2020/4077��6   $��16(�6E   $��Heavy"�6S   
�������$
��Left=�58      $��	0 30 0 15q�67   6L   �� 5<      $"��MINHAJ M.H.A. 
 EG/2020/4076��6   $��16(�6E   $��Heavy"�6S   
�������$
��Left=�5=      $��	0 30 0 15q�67   6L   � 5@      -   5        $��progressBar��5@      	 � Value$	 0Q�61   $��5��6;   $	��575��6F   $��0 40 0 0q�6R   
 � IsIndeterminate$

 True��6e   5B      5D      5F      5G      