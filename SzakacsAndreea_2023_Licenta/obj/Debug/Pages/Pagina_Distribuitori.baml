   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      <    6SzakacsAndreea_2023_Licenta.Pages.Pagina_Distribuitori   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:SzakacsAndreea_2023_Licenta.Pages  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      -   5          N� Title$  Pagina_Distribuitori��5       � 	Resources 5         distribuitorViewSource=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   &	        '       7 �� 5   
   6   �� 5   
   8   "  6I   .�5      ��  � �� �#ffccd46+   �� 5       � ��
 �   �6+   5      5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��250 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��0��6   $��DISTRIBUITORI��61   $��18(�5      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5       $��Center=�64   � 5"   
   $��1��6   $��10,10,10,10q�6   
�������	 � ColumnDefinitions	 5#      �� 5$      $��* �6#   �� 5%      $��* �6#   .+�5'      � $��0��6   $��10 10 10 10q�6#   	 5(      �� 5)      $	��140 �6'   �� 5*      $
��auto �6'    5,      �� 5-      $
��auto �6$   �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$    53      ��%�  '��       '�� �     �� 54      " ��6   .�55      ��  � ��$ 3q�63   �� 56       � ��$
 Left=�6@   �� 57       � ��$ Center=�6>   �� 58       � ��$ 16(�65   59      �� 5:      " ��6   .�5;      ��  � ��$ 3q�63   �� 5<       � ��$	 250��62   �� 5=       � ��$
 Left=�6@   �� 5>       � ��$ Center=�6>   �� 5?       � ��$ 25��63   5@      5A      .+�5C      �� $��Cod Distribuitor:��6   $��0��64   $��0��6A   �� 5D      -   5        
 ��Name$
 coddistribuitorTextBox��5D      $��0��6:   $��1��6G   ��6W   �� *CodDistribuitor+�� 5G      $��Distribuitor:��6   $��1��60   $��0��6=   �� 5H      -   5        $
 distribuitorTextBox��5H      $��1��67   $��1��6D   ��6T   �� *NumeDistribuitor+�� 5K      $��Cod Fiscal:��6   $��2��6.   $��0��6;   �� 5L      -   5        $
 codfiscalTextBox��5L      $��2��64   $��1��6A   ��6Q   �� *	CodFiscal+�� 5O      $��Telefon:��6   $��3��6+   $��0��68   �� 5P      -   5        $
 telefonTextBox��5P      $��3��62   $��1��6?   ��6O   �� *	Telefon+�� 5S      $��	Persoana:��6   $��4��6,   $��0��69   �� 5T      -   5         ��Name$ persoanaComboBox��5T      $��4��65   $��1��6B    �� Text 6R   �� *
Persoana+.@�5U      �� $��Fizica��6#   �� 5V      $��Juridica��6#   5W      5X      � 5Y      $��1��6   $��10 10 10 10q�6#   	 5Z      �� 5[      $	��140 �6'   �� 5\      $
��auto �6'    5^      �� 5_      $
��auto �6$   �� 5`      $
��auto �6$   �� 5a      $
��auto �6$   �� 5b      $
��auto �6$   �� 5c      $
��auto �6$    5g      ��%�  '��       '�� �     �� 5h      " ��6   .�5i      ��  � ��$ 3q�63   �� 5j       � ��$
 Left=�6@   �� 5k       � ��$ Center=�6>   �� 5l       � ��$ 16(�65   5m      �� 5n      " ��6   .�5o      ��  � ��$ 3q�63   �� 5p       � ��$	 250��62   �� 5q       � ��$
 Left=�6@   �� 5r       � ��$ Center=�6>   �� 5s       � ��$ 25��63   5t      5u      .+�5w      �� $��Sediu:��6   $��0��6)   $��0��66   �� 5x      -   5        $
 sediuTextBox��5x      $��0��60   $��1��6=   ��6M   �� *Sediu+�� 5z      $��Judet:��6   $��1��6)   $��0��66   �� 5{      -	   5        $ judetComboBox��5{      $��1��62   $��1��6?    6O   �� *Judet+.@�5|      �� $
��Alba��6#   �� 5}      $
��Arad��6#   �� 5~      $��Argeș��6#   �� 5      $��Bacău��6#   �� 5�      $��Bihor��6#   �� 5�      $��Bistrța-Năsăud��6#   �� 5�      $��	Botoșani��6#   �� 5�      $��Brașov��6#   �� 5�      $��Brăila��6#   �� 5�      $��	Bucuresti��6#   �� 5�      $��Buzău��6#   �� 5�      $��Caraș-Severin��6#   �� 5�      $��Călărași��6#   �� 5�      $
��Cluj��6#   �� 5�      $��
Constanța��6#   �� 5�      $��Covasna��6#   �� 5�      $��Dâmbovița��6#   �� 5�      $
��Dolj��6#   �� 5�      $��Galați��6#   �� 5�      $��Giurgiu��6#   �� 5�      $
��Gorj��6#   �� 5�      $��Harghita��6#   �� 5�      $��	Hunedoara��6#   �� 5�      $��	Ialomița��6#   �� 5�      $��Iași��6#   �� 5�      $��Ilfov��6#   �� 5�      $��
Maramureș��6#   �� 5�      $��
Mehedinți��6#   �� 5�      $��Mureș��6#   �� 5�      $��Neamț��6#   �� 5�      $	��Olt��6#   �� 5�      $��Prahova��6#   �� 5�      $��	Satu Mare��6#   �� 5�      $��Sălaj��6#   �� 5�      $��Sibiu��6#   �� 5�      $��Suceava��6#   �� 5�      $��	Teleorman��6#   �� 5�      $��Timiș��6#   �� 5�      $��Tulcea��6#   �� 5�      $��Vaslui��6#   �� 5�      $��Vâlcea��6#   �� 5�      $��Vrancea��6#   5�      �� 5�      $��Email:��6   $��2��6)   $��0��66   �� 5�      -
   5        $
 emailTextBox��5�      $��2��60   $��1��6=   ��6M   �� *Email+�� 5�      $��Obs Distribuitor:��6   $��3��64   $��0��6A   �� 5�      -   5        $
 obsDistribuitorTextBox��5�      $��3��6:   $��1��6G   ��6W   �� *ObsDistribuitor+�� 5�      $��Nr.Auto:��6   $��4��6+   $��0��68   �� 5�      -   5        $
 nrAutoTextBox��5�      $��4��61   $��1��6>   ��6N   �� *NrAuto+5�      5�      � 5�   
   $��2��6   $��0 0 10 0q�6   .+�5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� -   5         ��Name$ btnAdaugaDistribuitor��5�      $��30��68   $��85��6D   
�������
���   �
���   �$��Adaugă��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnEditeazaDistribuitor��5�      $��30��6:   $��85��6F   
�������
���   �
���   �$��Editeaza��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnStergereDistribuitor��5�      $��30��6:   $��85��6F   
�������
���   �
���   �$��Stergere��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnAnulareDistribuitor��5�      $��30��69   $��85��6E   
�������
���   �
���   �$��Anulare��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      $��Cauta dupa nume:��6   
���   �$��15(�6F   $��Center=�6T   $��Center=�5�      $��10q�6:   �� 5�      -   5        $��txtCautaDistribuitor��5�      $��30��5�      $��5 5 0 0q�6'   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CAUTA��68   $��Center=�5�   2   $	��174��6O   5�      5�      5�      � 5�   
   $��3��6   $��5,5,5,5q�6   .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ distribuitorDataGrid��5�         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5�   /   ��6   ��    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        codDistribuitorColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Cod Distribuitor��5�   l      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *CodDistribuitor+6�     5�      -   5        numeDistribuitorColumn��$ Nume Distribuitor��5�   n   $
 Auto 6�    6I   �� *NumeDistribuitor+6�     5�      -   5        codFiscalColumn��$ 
Cod Fiscal��5�   `   $
 Auto 6t    6B   �� *	CodFiscal+6t     5�      -   5        telefonColumn��$ Telefon��5�   \   $
 Auto 6m    6@   �� *	Telefon+6m     5�      -   5        persoanaColumn��$ Persoana��5�   ^   $
 Auto 6p    6A   �� *
Persoana+6p     5�      -   5        sediuColumn��$ Sediu��5�   X   $
 Auto 6g    6>   �� *Sediu+6g     5�      -   5        judetColumn��$ Judet��5�   X   $
 Auto 6g    6>   �� *Judet+6g     5�      -   5        emailColumn��$ Email��5�   X   $
 Auto 6g    6>   �� *Email+6g     5�      -   5        obsDistribuitorColumn��$ Obs Distribuitor��5�   l   $
 Auto 6�    6H   �� *ObsDistribuitor+6�     5�      -   5        nrAutoColumn��$ Nr Auto��5�   Z   $
 Auto 6k    6?   �� *NrAuto+6k   5�      5�      5�      5�      