   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      6    0SzakacsAndreea_2023_Licenta.Pages.Pagina_Clienti   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:SzakacsAndreea_2023_Licenta.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      -   5          N� Title$  Pagina_Clienti��5       � 	Resources 5         clientViewSource=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   &	        '       7 �� 5   
   6   �� 5      8   "  6M   .�5      ��  � �� �#ffccd46+   �� 5       � ��
 �   �6/   5      5      .��5      �  � DataContext# [  6   
������� � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��60 �6    �� 5      $��* �6    .+�5!   
   �� -   5         ��Name$ 
labelTitle��5!      $��0��6   $��CLIENȚI��61   $��18(�5"      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5$      $��Center=�64   �� 5&   
   	 �� Orientation$	 
Horizontal=�6   
�������$��Center=�6A   $
��Left=�6\   $��1��6w    5'      ��%�   '��       �� 5(      " ��6   .�5)      ��  � ��$ 80��6.   �� 5*       � ��$	 6,4q�6/   �� 5+       � ��$ 0q�68   �� 5,       � �� �#EEEEEE63   5-      5.      .+�51      �� -   5        
 ��Name$
 buttonEditData��51      $��80��6J   .��52      �� $	 
Horizontal=�6   .+�53      �� $��/Images/edit.png��6   $��24��66   �� 54      $��Editare��6    $��Center=�6/   $��4q�6J   55      56      �� 57      -   5        $
 buttonAddData��57      $��85��6H   .��58      �� $	 
Horizontal=�6   .+�59      �� $��/Images/add.png��6   $��24��65   �� 5:      $��Adaugare��6    $��Center=�60   $��4q�6K   5;      5<      �� 5=      -   5        $
 buttonDeleteData��5=      $��80��6N   .��5>      �� $	 
Horizontal=�6   .+�5?      �� $��/Images/delete.png��6   $��24��68   �� 5@      $��Stergere��6    $��Center=�60   $��4q�6K   5A      5B      �� 5D      -   5         ��Name$ clientiComboBox��5D       �� SelectedIndex$ 0��6e   $��50 5 5 5q�6w   
�������$	��200��6�   .@�5E      �� -   5        $��Filtare��5E      $��Filtare��6.   �� 5F      -   5        $
��Nume��5F      $
��Nume��6+   �� 5G      -	   5        $��Judet��5G      $��Judet��6,   5H      �� 5I      -
   5         ��Name$ 	SearchBox��5I      
�������$	��250��5J   ;   $��40��6G   $��Center=�6S   $
��Left=�5K      5M      � 5P   
   $��2��6   .+�5R      &   System.Windows.Controls.DataGrid  -   5          Name$ clientDataGrid��5R         RowDetailsVisibilityMode$ VisibleWhenSelected=�60      AutoGenerateColumns .     EnableRowVirtualization . $��10,10,10,10q�5T         SelectionUnit$ FullRow=�6)   ��5S   R   ��    Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5X      -   5        codClientColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Cod Client��5X   b      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	CodClient+6v     5Y      -   5        
numeColumn��$
 Nume��5Y   X   $
 auto 6f    6?   �� *Nume+6f     5Z      -   5        persoanaContactColumn��$ Persoana Contact��5Z   n   $
 auto 6�    6J   �� *PersoanaContact+6�     5[      -   5        telefonColumn��$ Telefon��5[   ^   $
 auto 6o    6B   �� *	Telefon+6o     5\      -   5        adresaColumn��$ Adresa��5\   ]   $
 auto 6m    6B   �� *Adresa+6m     5]      -   5        
orasColumn��$
 Oras��5]   W   $
 auto 6e    6>   �� *Oras+6e     5^      -   5        judetColumn��$ Judet��5^   Z   $
 auto 6i    6@   �� *Judet+6i   5a      5c      5e      5f      