   M S B A M L   `   `   `  ����F  BGUI_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GUI_Project.PagesGUI_Project.Pages  5      &     GUI_Project.Pages.PatientDetails   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GUI_Project.Pages     5        N� Title$  PatientDetails��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   �� $��15(�6   $
��Bold"�6"   $��0��64   $��Admitted Patients Details��6A   $��
50,20,0,20q�6b   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridPatientDetails��5       $��0��6      AutoGenerateColumns$
 True��6@   $
��Left=�6[   $	��250��6v   $	��800��6�   $��	30,45,0,0q�6�   $	��Top=�6�   �� 5   
   $��15(�6   $
��Bold"�6"   $!��Discharged Patients Details��64   $��50,310,0,20q�6W     5   
   -   5        $$ dataGridreleasedPatientDetails��5       $��0��6   $
 True��6H   $
��Left=�6c   $	��250��6~   $	��800��6�   $��
30,320,0,0q�6�   �� 5   
   $��1��6   ._�5      �� -   5        $��Exit ��5         
FullButton#��[  6;   5      5      5      