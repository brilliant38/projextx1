   M S B A M L   `   `   `  ����P  LDataContextBindingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DataContextBindingWPFDataContextBindingWPF  5   	   &     DataContextBindingWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DataContextBindingWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ Grid1��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   Name:68   �� 5   
   $��0��6   $��1��6$   City:68   �� 5   
   -   5         ��Name$ TextBox1��5      $��1��6$   $��0��5      ��6   ��  �� Path$ Ename�6=   �� 5   
   -   5        $ TextBox2��5      $��1��6$   $��1��5      ��6   �� $
 City�6<   �� 5   
   -   5        $��button1��5      $��1��5      $��2��6!   .��5   1   Control To Context6E   5      5      