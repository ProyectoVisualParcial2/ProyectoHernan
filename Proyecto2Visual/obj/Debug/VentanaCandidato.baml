   M S B A M L   `   `   `  ����J  FProyecto2Visual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Proyecto2VisualProyecto2Visual  5   	   &     Proyecto2Visual.VentanaCandidato   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Proyecto2Visual     5   	   -   5          � Title$  VentanaCandidato��5   	   $	��500��6"   $��640.5��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Agregar Candidato��6   $
��Left=�6;   $��	10,20,0,0q�6V   $	��Top=�6i   $��38��6�   $	��261��6�   $��20(�6�   $��Center=�6�   $
��Bold"�6�   �� 5   
   $��Nombre:��6   $
��Left=�6"   $��	19,76,0,0q�6=   $	��Top=�6P   �� 5   
   $��	Apellido:��6   $
��Left=�6$   $��
19,115,0,0q�6?   $	��Top=�6S   �� 5   
   $��Edad:��6   $
��Left=�6    $��
33,156,0,0q�6;   $	��Top=�6O   �� 5   
   $
��Left=�6'   $��
120,20,0,0q�6B   $	��Top=�6V   ��6   �� *Id+6V   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��23��6@   $��	89,80,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��168��6�   ��6�   �� *Nombre+�� 5   
   -   5        $ txtApellido��5      $
��Left=�6'   $��23��6B   $��
89,118,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��168��6�   ��6�   �� *
Apellido+�� 5   
   -   5        $ txtEdad��5      $
��Left=�6#   $��23��6>   $��
89,160,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��168��6�   ��6�   �� *Lugar+�� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
53,353,0,0q�6R   $	��Top=�6f   $��75��6~   �� 5   
   -   5        $ 	btnCerrar��5      $��Cerrar��6$   $
��Left=�65   $��144,353,0,0q�6P   $	��Top=�6e   $��75��6}   �� 5   
   $��Usuario:��6   $
��Left=�6#   $��
19,201,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $ 
txtUsuario��5      $
��Left=�6&   $��23��6A   $��
89,205,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��168��6�   ��6�   �� *Nombre+�� 5   
   $��Clave:��6   $
��Left=�6!   $��
31,247,0,0q�6<   $	��Top=�6P   �� 5   
   -	   5        $ txtClave��5      $
��Left=�6$   $��23��6?   $��
89,250,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��168��6�   ��6�   �� *Nombre+�� 5   
   $��	Dignidad:��6   $
��Left=�6$   $��
14,291,0,0q�6?   $	��Top=�6S   �� 5   
   -
   5         ��Name$ cbxDignidad��5      $
��Left=�6(   $��
89,291,0,0q�6C   $	��Top=�6W   $	��168��6o   .@�5      �� $��
presidente��6   �� 5      $��asambleista��6   �� 5      $��prefecto��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridPersona��5      $��Center=�6,   $��304,20,22,216q�6I   $��Center=�6`   $	��233��6{   $	��306��6�      AutoGenerateColumns .     EnableRowVirtualization .  ��6�   �� 	 �� Path$	 tblPersonas�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nombre+6A     5!      $ Apellido��6C    6%   �� *
Apellido+6C     5"      $
 Edad��6?    6%   �� *Edad+6?     5#      $	 Rol��6>    6%   �� *Rol+6>   5%        5&   
   -   5        $ dataGridCandidato��5&      $��Center=�6.   $��304,273,22,31q�6K   $��Center=�6b   $	��165��6}   $	��306��6�    .   .  ��6�   �� *tblCandidato+
 5'        5(      $ Usuario��6B    6%   �� *	usuario+6B     5)      $ Clave��6@    6%   �� *clave+6@   5+      5-      5.      