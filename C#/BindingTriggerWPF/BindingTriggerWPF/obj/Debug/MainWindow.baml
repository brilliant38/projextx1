   M S B A M L   `   `   `  ����L  HBindingTriggerWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BindingTriggerWPFBindingTriggerWPF  5   	   "    BindingTriggerWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BindingTriggerWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         MyStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� ElementName �� Path	 �� Value��%�  &	        '� �     �� 5
   
   " ��6    .�5      ��  � y�$ Visible=�6+    5      �� 5       6   �� $	 cb1��$ 	IsChecked�	 True5      .a�5      ��  � y�$ Hidden=�63   5      5      �� 5   
   " �6   .�5      ��  � ��
 ��  �6+    5      �� 5       6   �� *
TheValue+	 206;   .a�5      ��  � ��
 �  ��63   5      5      5      .��5%      � 
 � RowDefinitions
 5&   
   �� 5'      �� 5(      �� 5)      .+�5-   
   �� -   5         ��Name$ MySlider��5-      $��5q�6#    � Minimum$ 0Q�6.    � Maximum$ 20Q�6:    � Value 5.      �� *
TheValue+� 50   
   $��1��6   $ 0Q�6#   $ 20Q�6/    6<   �� *
TheValue+�� 53   
   $��2��6   ��6   �� *
TheValue+54      57      