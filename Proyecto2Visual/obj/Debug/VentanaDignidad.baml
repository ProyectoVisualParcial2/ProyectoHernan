   M S B A M L   `   `   `  ����J  FProyecto2Visual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Proyecto2VisualProyecto2Visual  5   	   %    Proyecto2Visual.VentanaDignidad   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Proyecto2Visual     5   	   -   5          � Title$  VentanaDignidad��5   	   $	��400��6!   $	��300��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Agregar Dignidad��6   $
��Left=�6:   $��	10,20,0,0q�6U   $	��Top=�6h   $��38��6�   $	��261��6�   $��20(�6�   $��Center=�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dataGrid1��5      $��Center=�6&   $��60,63,66,190q�6C   $��Center=�6Y   $	��100��6t   $	��100��6�      AutoGenerateColumns .     EnableRowVirtualization .  ��6�   ��  �� Path$ tblDignidades�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nombre+6A   5      �� 5   
   $��Nombre:��6   $
��Left=�6"   $��
33,205,0,0q�6=   $	��Top=�6Q   �� 5   
   $
��Left=�6'   $��
120,20,0,0q�6B   $	��Top=�6V   ��6   �� *Id+6V   �� 5   
   -   5        	 ��Name$	 	txtNombre��5      $
��Left=�6%   $��23��6@   $��103,209,0,0q�6L   
 �� TextWrapping$

 Wrap=�6a   $	��Top=�6u   $	��168��6�   ��6�   �� *Nombre+�� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
60,263,0,0q�6R   $	��Top=�6f   $��75��6~   �� 5   
   -   5        $ 	btnCerrar��5      $��Cerrar��6$   $
��Left=�65   $��151,263,0,0q�6P   $	��Top=�6e   $��75��6}   5      5      