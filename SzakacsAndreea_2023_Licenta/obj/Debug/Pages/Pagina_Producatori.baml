   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      :    4SzakacsAndreea_2023_Licenta.Pages.Pagina_Producatori   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:SzakacsAndreea_2023_Licenta.Pages  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      -   5          N� Title$  Pagina_Producatori��5       � 	Resources 5         producatorViewSource=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�   &	        '       7 �� 5   
   6   �� 5   
   8   "  6I   .�5      ��  � �� �#ffccd46+   �� 5       � ��
 �   �6+   5      5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��250 �6   �� 5      $��50 �6   �� 5      $	��345 �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��0��6   $��PRODUCATORI��61   $��18(�5      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5!      $��Center=�64   � 5#   
   $��1��6   $��10,10,10,10q�6   
�������	 � ColumnDefinitions	 5$      �� 5%      $��* �6#   �� 5&      $��* �6#   .+�5(      � $��0��6   $��10 10 10 10q�6#   	 5)      �� 5*      $	��150 �6'   �� 5+      $
��auto �6'    5-      �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$    54      ��%�  '��       '�� �     �� 55      " ��6   .�56      ��  � ��$ 3q�63   �� 57       � ��$
 Left=�6@   �� 58       � ��$ Center=�6>   �� 59       � ��$ 16(�65   5:      �� 5;      " ��6   .�5<      ��  � ��$ 3q�63   �� 5=       � ��$	 250��62   �� 5>       � ��$
 Left=�6@   �� 5?       � ��$ Center=�6>   �� 5@       � ��$ 25��63   5A      5B      .+�5D      �� $��Cod Producator:��6   $��0��62   $��0��6?   �� 5E      -   5        
 ��Name$
 codproducatorTextBox��5E      $��0��68   $��1��6E   ��6U   �� *CodProducator+�� 5H      $��Producator:��6   $��1��6.   $��0��6;   �� 5I      -   5        $
 producatorTextBox��5I      $��1��65   $��1��6B   ��6R   �� *Nume+�� 5L      $��Persoana Contact:��6   $��2��64   $��0��6A   �� 5M      -   5        $
 persoanacontactTextBox��5M      $��2��6:   $��1��6G   ��6W   �� *PersoanaContact+5R      � 5S      $��1��6   $��10 10 10 10q�6#   	 5T      �� 5U      $	��120 �6'   �� 5V      $
��auto �6'    5X      �� 5Y      $
��auto �6$   �� 5Z      $
��auto �6$   �� 5[      $
��auto �6$   �� 5\      $
��auto �6$    5a      ��%�  '��       '�� �     �� 5b      " ��6   .�5c      ��  � ��$ 3q�63   �� 5d       � ��$
 Left=�6@   �� 5e       � ��$ Center=�6>   �� 5f       � ��$ 16(�65   5g      �� 5h      " ��6   .�5i      ��  � ��$ 3q�63   �� 5j       � ��$	 250��62   �� 5k       � ��$
 Left=�6@   �� 5l       � ��$ Center=�6>   �� 5m       � ��$ 25��63   5n      5o      .+�5q      �� $��Tara:��6   $��0��6(   $��0��65   �� 5r      -   5        $
 taraTextBox��5r      $��0��6/   $��1��6<   ��6L   �� *Tara+�� 5u      $��Oras:��6   $��1��6(   $��0��65   �� 5v      -   5        $
 orasTextBox��5v      $��1��6/   $��1��6<   ��6L   �� *Oras+�� 5x      $��Adresa:��6   $��2��6*   $��0��67   �� 5y      -   5        $
 adresaTextBox��5y      $��2��61   $��1��6>   ��6N   �� *Adresa+�� 5{      $��Telefon:��6   $��3��6+   $��0��68   �� 5|      -	   5        $
 telefonTextBox��5|      $��3��62   $��1��6?   ��6O   �� *	Telefon+5}      5~      � 5�   
   $��2��6   $��0 0 0 0q�6   .+�5�      ��  �� Orientation$ 
Horizontal=�6   $��10 0 0 0q�62   .+�5�      �� -
   5         ��Name$ btnAdaugaProducator��5�      $��30��66   $��85��6B   
�������
���   �
���   �$��Adaugă��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnEditeazaProducator��5�      $��30��68   $��85��6D   
�������
���   �
���   �$��Editeaza��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnAnulareDate��5�      $��30��61   $��85��6=   
�������
���   �
���   �$��Anulare��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      -   5        $ btnStergereDate��5�      $��30��62   $��85��6>   
�������
���   �
���   �$��Stergere��5�   <   $��Bottom=�5�      $��10q�60   $��Right=�6<   5�      �� 5�      $��Cauta dupa Nume:��6   
���   �$��15(�6F   $��Center=�6T   $��Center=�5�      $��10q�6:   �� 5�      -   5        $��txtCautaProducator��5�      $��30��64   $��10 5 5 0q�6A   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CAUTA��6S   $��Right=�5�      $	��174��63   5�      5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ producatorDataGrid��5�         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5�   +   $��5,0,5,0q�5�      $��3��6$   $	��310��6h   $	��Top=�6u   ��5�      ��    Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        codProducatorColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Cod Producator��5�   d      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6|   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *CodProducator+6|     5�      -   5        
numeColumn��$
 Nume��5�   R   $
 Auto 6`    69   �� *Nume+6`     5�      -   5        persoanaContactColumn��$ Persoana Contact��5�   h   $
 Auto 6�    6D   �� *PersoanaContact+6�     5�      -   5        telefonColumn��$ Telefon��5�   X   $
 Auto 6i    6<   �� *	Telefon+6i     5�      -   5        
taraColumn��$
 Tara��5�   R   $
 Auto 6`    69   �� *Tara+6`     5�      -   5        
orasColumn��$
 Oras��5�   R   $
 Auto 6`    69   �� *Oras+6`     5�      -   5        adresaColumn��$ Adresa��5�   V   $
 Auto 6f    6;   �� *Adresa+6f   5�      5�      5�      