   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      9    3SzakacsAndreea_2023_Licenta.Pages.Pagina_Sortimente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:SzakacsAndreea_2023_Licenta.Pages  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      -   5          N� Title$  Pagina_Sortimente��5       � 	Resources 5         sortimenteViewSource��%   &	        �� 5   
   6   5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��250 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��0��6   $��
SORTIMENTE��61   $��18(�5      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5      $��Center=�64   � 5   
   $��1��6   $��10,10,10,10q�6   
������� � ColumnDefinitions 5       �� 5!      $��* �6#   �� 5"      $��* �6#   .+�5$      � $��0��6   $��10 10 10 10q�6#    5%      �� 5&      $	��140 �6'   �� 5'      $
��auto �6'    5)      �� 5*      $
��auto �6$   �� 5+      $
��auto �6$   �� 5,      $
��auto �6$   �� 5-      $
��auto �6$    5/       �� 
TargetType �� Property �� Value��%�  '��       '�� �     �� 50      " ��6   .�51      ��  � ��$ 3q�63   �� 52       � ��$
 Left=�6@   �� 53       � ��$ Center=�6>   �� 54       � ��$ 16(�65   55      �� 56      " ��6   .�57      ��  � ��$ 3q�63   �� 58       � ��$	 250��62   �� 59       � ��$
 Left=�6@   �� 5:       � ��$ Center=�6>   �� 5;       � ��$ 25��63   5<      5=      .+�5?      �� $��Cod Sortiment:��6   $��0��61   $��0��6>   �� 5@      -   5        	 ��Name$	 codsortimentTextBox��5@      $��0��67   $��1��6D   ��6T   �� *CodSortiment+�� 5C      $��
Sortiment:��6   $��1��6-   $��0��6:   �� 5D      -   5        $	 sortimentTextBox��5D      $��1��64   $��1��6A   ��6Q   �� *	Sortiment+�� 5G      $��Cod Producator:��6   $��2��62   $��0��6?   �� 5H      -   5        $	 codproducatorTextBox��5H      $��2��68   $��1��6E   ��6U   �� *CodProducator+�� 5K      $��Origine:��6   $��3��6+   $��0��68   �� 5L      -   5        $	 origineTextBox��5L      $��3��62   $��1��6?   ��6O   �� *	Origine+5N      5O      � 5Q   
   $��2��6   $��0 0 10 0q�6   .+�5R      �� 
 �� Orientation$
 
Horizontal=�6   .+�5S      �� -   5         ��Name$ btnAdaugaSortiment��5S      $��30��65   $��85��6A   
�������
���   �
���   �$��Adaugă��5T   <   $��Bottom=�5U      $��10q�60   $��Right=�6<   5V      �� 5W      -   5        $ btnEditeazaSortiment��5W      $��30��67   $��85��6C   
�������
���   �
���   �$��Editeaza��5X   <   $��Bottom=�5Y      $��10q�60   $��Right=�6<   5Z      �� 5\      -	   5        $ btnStergereSortiment��5\      $��30��67   $��85��6C   
�������
���   �
���   �$��Stergere��5]   <   $��Bottom=�5^      $��10q�60   $��Right=�6<   5_      �� 5a      -
   5        $ btnAnulareSortiment��5a      $��30��66   $��85��6B   
�������
���   �
���   �$��Anulare��5b   <   $��Bottom=�5c      $��10q�60   $��Right=�6<   5d      �� 5e      $��Cauta dupa origine:��6   
���   �$��15(�6I   $��Center=�6W   $��Center=�5f      $��10q�6:   �� 5g      -   5        $��txtCautaOrigine��5h      $��30��5g      $��5 5 0 0q�6'   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CAUTA��68   $��Center=�5h   -   $	��174��6J   5i      5k      5l      &   System.Windows.Controls.DataGrid  5m   
   -   5          Name$ sortimenteDataGrid��5m         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5n   +   $��3��6Z   ��6   ��    Columns 5p      0  *System.Windows.Controls.DataGridTextColumn  5q      -   5        codSortimentColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Cod Sortiment��5q   b      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *CodSortiment+6y     5r      -   5        codProducatorColumn��$ Cod Producator��5r   d   $
 Auto 6|    6B   �� *CodProducator+6|     5s      -   5        origineColumn��$ Origine��5s   X   $
 Auto 6i    6<   �� *	Origine+6i     5t      -   5        sortimentColumn��$ 	Sortiment��5t   \   $
 Auto 6o    6>   �� *	Sortiment+6o   5v      5x      5y      