   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      _4clr-namespace:SzakacsAndreea_2023_Licenta.Converters&SzakacsAndreea_2023_Licenta.Converters  5	      6    0SzakacsAndreea_2023_Licenta.Pages.Pagina_Produse   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:SzakacsAndreea_2023_Licenta.Pages  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      E
Converters4clr-namespace:SzakacsAndreea_2023_Licenta.Converters  5	      -   5          N� Title$  Pagina_Produse��5       � 	Resources 5         produsViewSource=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value;   5SzakacsAndreea_2023_Licenta.Converters.ImageConverter  ImageConverter��%�   &	        '       7 &	 �     �� 5   
   6   �� 5   
   8   "  6I   .�5      ��  � �� �#ffccd46+   �� 5       � ��
 �   �6+   5        5   
   6$   5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��220 �6   �� 5      $��60 �6   �� 5      $��* �6   .+�5!   
   �� -   5         ��Name$ 
labelTitle��5!      $��0��6   $��PRODUSE��61   $��18(�5"      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5$      $��Center=�64   � 5%   
   $��1��6   $��5 5 5 5q�6   
�������	 � ColumnDefinitions	 5&      �� 5'      $	��400 �6#   �� 5(      $	��400 �6#   �� 5)      $��* �6#   .+�5+      � $��0��6   $��10,10,10,10q�6#   	 5,      �� 5-      $	��150 �6'   �� 5.      $
��auto �6'    50      �� 51      $
��auto �6$   �� 52      $
��auto �6$   �� 53      $
��auto �6$   �� 54      $
��auto �6$   �� 55      $
��auto �6$    58      ��%�  '��       '�� �     �� 59      " ��6   .�5:      ��  � ��$ 3q�63   �� 5;       � ��$
 Left=�6@   �� 5<       � ��$ Center=�6>   �� 5=       � ��$ 16(�65   5>      �� 5?      " ��6   .�5@      ��  � ��$ 3q�63   �� 5A       � ��$	 250��62   �� 5B       � ��$
 Left=�6@   �� 5C       � ��$ Center=�6>   �� 5D       � ��$ 25��63   5E      5F      .+�5H      �� $��Cod Produs:��6   $��0��6.   $��0��6;   �� 5I      -   5        
 ��Name$
 codprodusTextBox��5I      $��1��64   $	��220��6_   ��6D   �� *	CodProdus+6_   �� 5L      $��Denumire produs:��6   $��1��63   $��0��6@   �� 5M      -   5        $
 denumireprodusTextBox��5M      $��1��69   $��1��6F   $	��220��6v   ��6V   �� *DenumireProdus+6v   �� 5O      $��Cod Sortiment:��6   $��3��61   $��0��6>   �� 5P      -   5        $
 codsortimentTextBox��5P      $��3��67   $��1��6D   $	��220��6r   ��6T   �� *CodSortiment+6r   �� 5R      $��
Sortiment:��6   $��4��6-   $��0��6:   �� 5S      -   5         ��Name$ sortimentTextBox��5S      $��4��65   $��1��6B   $	��220��6m    �� Text 6R   �� *	Sortiment+.@�5T      �� $��Cafea Arabica��6#   �� 5U      $��Cafea Robusta��6#   �� 5V      $��Cafea Bourbon��6#   �� 5W      $��Cafea Supremo��6#   �� 5X      $��Cafea Juan Valdez��6#   �� 5Y      $��Cafea Excelso��6#   �� 5Z      $��Cafea Sidamo��6#   �� 5[      $��Cafea Monsooned Malabar��6#   �� 5\      $��Cafea Chiapas��6#   �� 5]      $��Cafea Sumatra��6#   �� 5^      $��Cafea Yirgacheffee��6#   5_      5`      � 5b      $��1��6   $��10 10 10 10q�6#   	 5c      �� 5d      $	��150 �6'   �� 5e      $
��auto �6'    5g      �� 5h      $
��auto �6$   �� 5i      $
��auto �6$   �� 5j      $
��auto �6$    5n      ��%�  '��       '�� �     �� 5o      " ��6   .�5p      ��  � ��$ 3q�63   �� 5q       � ��$
 Left=�6@   �� 5r       � ��$ Center=�6>   �� 5s       � ��$ 16(�65   5t      �� 5u      " ��6   .�5v      ��  � ��$ 3q�63   �� 5w       � ��$	 250��62   �� 5x       � ��$
 Left=�6@   �� 5y       � ��$ Center=�6>   �� 5z       � ��$ 25��63   5{      5|      .+�5~      �� $��
Cantitate:��6   $��0��6-   $��0��6:   �� 5      -   5        $
 cantitateTextBox��5      $��0��64   $��1��6A   $	��220��6l   ��6Q   �� *	Cantitate+6l   �� 5�      $��Pret:��6   $��1��6(   $��0��65   �� 5�      -   5        $
 pretTextBox��5�      $��1��6/   $��1��6<   $	��220��6b   ��6L   �� *Pret+6b   �� 5�      $��
Descriere:��6   $��2��6-   $��0��6:   �� 5�      -	   5        $
 descriereTextBox��5�      $��2��64   $��1��6A   $	��120��6Q   $	��220��6y    �� TextWrapping$
 Wrap=�6�   ��6^   �� *	Descriere+6�   5�      � 5�      $��2��6   	 5�      �� 5�      $	��250 �6'   �� 5�      $
��auto �6'   .+�5�      � $��0��6   .+�5�      �� $��40 5 5 5q�6   
�������$	��150��6?   
�������$��1q�6c   ._�5�      �� -
   5         ��Name$ Imagineprodus��5�      ��63   �� *	Imagine+ �� 	Converter# [ 5�      5�      � 5�      $��1��6   $��0 0 10 0q�6'   .+�5�      �� -   5         ��Name$ buttonLoadFromFile��5�   !   $�� Incarca o imagine ��6=   $	��150��6[   6j   5�      5�      5�      � 5�   
   $��2��6   $��0 0 10 0q�6   .+�5�   
   ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� -   5        $ btnAdaugaProdus��5�      $��30��6.   $	��150��6:   
�������
���   �
���   �$��Adaugă Produs��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnStergeProdus��5�      $��30��6.   $��85��6:   
�������
���   �
���   �$��Sterge��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnEditareProdus��5�      $��30��6/   $��85��6;   
�������
���   �
���   �$��Editare��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnAnulareProdus��5�      $��30��6/   $��85��6;   
�������
���   �
���   �$��Anulare��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      $��Cauta dupa denumire:��6   
���   �$��15(�6J   $��Center=�6X   $��Center=�5�      $��10q�6:   �� 5�      -   5        $��txtNameToSearch��5�      $��30��5�      $��5 5 0 0q�6'   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CAUTA��68   $��Center=�5�   -   $	��174��6J   5�      5�      5�      � 5�   
   $��3��6   $��10 10 10 10q�6   .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ produsDataGrid��5�   +   
�������   AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5�   +   ��6   ��    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        codProdusColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Cod Produs��5�   `      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	CodProdus+6t   4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      -   5        photoColumn��$ Imagine��5�   B   $ 80 6S      MinWidth$ 48Q�6^    	  CellTemplate 5�      �� 5�      .R�5�   "   �� ��6(   �� *	Imagine+# [ 5�      5�        5�      -   5        codsortimentColumn��$ CodSortiment��5�   f   $
 Auto 6|    6E   �� *CodSortiment+6|     5�      -   5        sortimentColumn��$ 	Sortiment��5�   `   $
 Auto 6s    6B   �� *	Sortiment+6s     5�      -   5        denumireColumn��$ Denumire Produs��5�   d   $
 Auto 6}    6A   �� *DenumireProdus+6}     5�      -   5        cantitateColumn��$ 	Cantitate��5�   `   $
 Auto 6s    6B   �� *	Cantitate+6s     5�      -   5        
pretColumn��$
 Pret��5�   V   $
 Auto 6d    6=   �� *Pret+6d     5�      -   5        descriereColumn��$ 	Descriere��5�   `   $
 Auto 6s    6B   �� *	Descriere+6s   5�      5�      5�      5�      