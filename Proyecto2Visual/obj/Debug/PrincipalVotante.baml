   M S B A M L   `   `   `  ����J  FProyecto2Visual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Proyecto2VisualProyecto2Visual  5   	   &     Proyecto2Visual.PrincipalVotante   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Proyecto2Visual     5   	   -   5          � Title$  PrincipalVotante��5   	   $��499.77��6"   $��517.105��62   .��5	      � $��0,0,-8,0q�6   .+�5
   
   �� -   5         ��Name$ label��5
      $��
Presidente��6   $
��Left=�64   $��	34,54,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label1��5      $��Prefecto��6    $
��Left=�63   $��
34,160,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ label2��5      $��Asambleista��6    $
��Left=�66   $��
34,265,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ label3��5      $��Votaciones 2017��6    $
��Left=�6:   $��
182,23,0,0q�6U   $	��Top=�6i   $��22(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridPresidentes��5      $��Center=�60   $��62,88,72,311q�6M   $��Center=�6c   $��70��6~   $	��383��6�      AutoGenerateColumns .     EnableRowVirtualization .  ��6�   ��  �� Path$ tblPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6=     5      $ Nombre��6A    6%   �� *Nombre+6A     5      $ Apellido��6H    6%   �� $ Apellido�6H   5        5   
   -   5        $ dataGridAsambleistas��5      $��Center=�61   $��62,301,72,98q�6N   $��Center=�6d   $��70��6   $	��383��6�    .   .  ��6�   �� $ tblPersonas� 5        5      $ ID��6=    6%   �� *Id+6=     5      $ Nombre��6A    6%   �� *Nombre+6A     5      $ Apellido��6H    6%   �� $ Apellido�6H   5        5    
   -   5        $ dataGridPrefectos��5       $��Center=�6.   $��62,192,72,208q�6K   $��Center=�6b   $��69��6}   $	��383��6�    .   .  ��6�   �� $ tblPersonas� 5!        5"      $ ID��6=    6%   �� *Id+6=     5#      $ Nombre��6A    6%   �� *Nombre+6A     5$      $ Apellido��6H    6%   �� $ Apellido�6H   5(      �� 5)   
   -	   5        	 ��Name$	 	btnCerrar��5)      $��Cerrar��6$   $
��Left=�65   $	��Top=�6P   $	��112��6h   $��182,400,0,0q�6t   $��32��6�   5*      5+      