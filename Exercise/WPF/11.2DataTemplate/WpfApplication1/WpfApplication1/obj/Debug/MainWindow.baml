   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)    � 	Resources 5	      *   $WpfApplication1.NameToImageConverter   NTI)   #WpfApplication1.NameToLogoConverter  NTL  playTemplate �� Orientation �� 	Converter  imageTemplate��%�  &	        &	      &	 &     7  &	 �    7     5
   
   6%     5   
   6$   �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��30��6   $��30��6#   $��	20,10,0,0q�6f   $
��Fill=�6y   ��6/   �� *Name+8   6y   �� 5      $��30��6   $��30��6'   $��	20,10,0,0q�6I   ��63   �� *Age+6I   �� 5      $��60��6   $��30��6'   $��	20,10,0,0q�6L   ��63   �� *Nation+6L   �� 5      $��60��6   $��30��6'   $��	20,10,0,0q�6J   ��63   �� *Club+6J   5      5      �� 5   
   .R�5      �� .+�5      �� $	��263��6   $	��192��6$   $
��Fill=�6h   ��61   �� *Name+8   6h   5      5      5      .��5      � -   5         �Name$ grid1��5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5       �� -   5         ��Name$ listBox1��5       $
��Auto��6(   #��[ 65   5&      5'      �� 5*   
   $��1��6   $	��350��6�   $
��Fill=�6�   ��6    �� *SelectedItem.Name+# [   �� ElementName$ listBox1����6y   �� *Width+$ grid1��6�   5+      5,      