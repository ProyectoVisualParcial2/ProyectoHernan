   M S B A M L   `   `   `  ����  Proyecto2Visual*    $Proyecto2Visual.MostrarResultadosCan   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          � Title$  MostrarResultados��5      $��538.464��6   $��584.359��60   .��5      � -   5         �Name$ gridVentana��5      $��0,0,-8,4q�6    .+�5   
   �� -   5         ��Name$ label��5      $��
Presidente��6   $
��Left=�64   $��	34,48,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label1��5      $��Prefecto��6    $
��Left=�63   $��	34,48,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $ label2��5      $��Asambleista��6    $
��Left=�66   $��	34,48,0,0q�6Q   $	��Top=�6d   �� 5	   
   -   5        $ label3��5	      $��Votaciones 2017��6    $
��Left=�6:   $��
182,10,0,0q�6U   $	��Top=�6i   $��22(�6�   &   System.Windows.Controls.DataGrid  5
   
   -   5          Name$ dataGridMosPresidentes��5
      $��Center=�63   $��39,95,380,222q�6P   $��Center=�6g   $	��186��6�   $	��165��6�      AutoGenerateColumns .     EnableRowVirtualization .  ��6�   ��  �� Path$ tblPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6A   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Nombre+6A     5      $ Apellido��6H   	 6%   �� $ Apellido�6H   5        5   
   -   5        $ dataGridVotosPresidentes��5      $��Center=�65   $��231,95,293,222q�6R   $��Center=�6j   $	��186��6�   $��60��6�    .   .  ��6�   �� $ tblCandidato� 5        5      $ Votos��6@   	 6%   �� *votos+6@   5        5   
   -	   5        $ dataGridMosAsambleistas��5      $��Center=�64   $��39,95,380,222q�6Q   $��Center=�6h   $	��186��6�   $	��165��6�    .   .  ��6�   �� $ tblPersonas� 5        5      $ Nombre��6A   	 6%   �� *Nombre+6A     5      $ Apellido��6H   	 6%   �� $ Apellido�6H   5        5   
   -
   5        $ dataGridVotosAsambleistas��5      $��Center=�66   $��231,95,293,222q�6S   $��Center=�6k   $	��186��6�   $��60��6�    .   .  ��6�   �� $ tblCandidato� 5        5      $ Votos��6@   	 6%   �� *votos+6@   5        5    
   -   5        $ dataGridMosPrefectos��5       $��Center=�61   $��39,95,380,222q�6N   $��Center=�6e   $	��186��6�   $	��165��6�    .   .  ��6�   �� $ tblPersonas� 5!        5"      $ Nombre��6A   	 6%   �� *Nombre+6A     5#      $ Apellido��6H   	 6%   �� $ Apellido�6H   5&        5'   
   -   5        $ dataGridVotosPrefectos��5'      $��Center=�63   $��231,95,293,222q�6P   $��Center=�6h   $	��186��6�   $��60��6�    .   .  ��6�   �� $ tblCandidato� 5(        5)      $ Votos��6@   	 6%   �� *votos+6@   5+      5-      5.      