   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      6    0SzakacsAndreea_2023_Licenta.Pages.Pagina_Comenzi   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:SzakacsAndreea_2023_Licenta.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      -   5          N� Title$  Pagina_Comenzi��5       � 	Resources 5         comandaViewSource  detaliiComandaViewSource �� Source=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   &	        &	      '  ;     7 �� 5   
   6   �� 5   
   $ DetaliiComanda��6@   �� 5   
   8   "  6I   .�5      ��  � �� �#ffccd46+   �� 5       � ��
 �   �6+   5      5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��60 �6   �� 5      $	��590 �6   .+�5    
   �� -   5        	 ��Name$	 
labelTitle��5       $��0��6   $��COMENZI��61   $��18(�5!      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5#      $��Center=�64   � 5&   
   $��2��6   $��5 5 5 20q�6    5(      �� 5)      $	��200 �6    �� 5*      $��30 �6    �� 5+      $��* �6    .+�51      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 comandaDataGrid��51         AutoGenerateColumns .     EnableRowVirtualization .     RowDetailsVisibilityMode$ VisibleWhenSelected=�52   +   $��0��6[   $��
10,0,10,20q�53   G   |�.  ��52      ��    Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      -   5        codClientColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Cod Client��55   `      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	CodClient+6t     56      -   5        iDComandaColumn��$ 	IDComanda��56   `   $
 Auto 6s    6B   �� *	IDComanda+6s     57      -   5        adresaLivrareColumn��$ Adresa Livrare��57   h   $
 Auto 6�    6F   �� *AdresaLivrare+6�     58      -   5        codDistribuitorColumn��$ Cod Distribuitor��58   l   $
 Auto 6�    6H   �� *CodDistribuitor+6�     59      -   5        orasLivrareColumn��$ Oras Livrare��59   d   $
 Auto 6z    6D   �� *OrasLivrare+6z     5:      -	   5        judetLivrareColumn��$ Judet Livrare��5:   f   $
 Auto 6}    6E   �� *JudetLivrare+6}     5;      -
   5        datacomandaColumn��$ Data Comanda��5;   }   $
 Auto 6�    6D   �� *DataComanda+ �� StringFormat$ 
dd.MM.yyyy��6�   5=      �� 5>      -   5        $	 labelDetalii��5>   6   $��1��6   ���#e59a9a$��Detalii Comanda��6L   $��16(�5?      $��DemiBold"�6   
���   �$��Center=�6G   $��Center=�6k   � 5@      $��2��6   .+�5B        -   5        $
 detaliiComandaDataGrid��5B       .   .    
IsReadOnly . $ VisibleWhenSelected=�5D      $��10,20,450,0q�6J   ��5C      ��  �� Source# [  5F        5G      -   5        iDComandaColumn1��$ 	IDComanda��5G   a   $
 Auto 6t    6C   �� *	IDComanda+6t     5H      -   5        codProdusColumn��$ 
Cod Produs��5H   `   $
 Auto 6t    6B   �� *	CodProdus+6t     5I      -   5        cantitateColumn��$ 	Cantitate��5I   `   $
 Auto 6s    6B   �� *	Cantitate+6s     5J      -   5        
pretColumn��$
 Pret��5J   V   $
 Auto 6d    6=   �� *Pret+6d     5K      -   5        	sumColumn��$
 Suma��5K   U   $
 Auto 6c    6<   �� *Suma+6c   5P      (  "MaterialDesignThemes.Wpf.ColorZone  5R      $��2��6'   $��900 50 40 100q�64      CornerRadius$ 15��6K   $��90��6]      Mode$ Custom=�6i   
�������
�������$��20 10q�5S   :   .��5T      �  � ColumnDefinitions 5U      �� 5V      $	��30* �6+   �� 5W      $	��52* �6+   .+�5Z      '  !MaterialDesignThemes.Wpf.PackIcon  $��0��6.      Kind$
 Cash=�6>   $��50��6J   $��50��6V   $
��Left=�6a   $��Center=�6|   
�������$��0 0 0 0q�5[   A   �� 5\      $��1��6!   $��Center=�61   $��50��6L   $��0q�6X   .+�5]      �� $��Total Comanda��6$   $��18(�69   $
��Bold"�6G   �� 5^      -   5        $	 txtTotal��5^   1   $��1��6    
�������$��16(�6V   5b      5c      5e      5f      5h      5m      5n      