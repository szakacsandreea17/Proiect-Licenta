   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SzakacsAndreea_2023_LicentaSzakacsAndreea_2023_Licenta  5   	   0    *SzakacsAndreea_2023_Licenta.Detalii_Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:SzakacsAndreea_2023_Licenta     5   	   -   5          � Title$  Detalii_Client��5   	   $	��370��6    $	��400��6-   .��5	      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��0��6   $��CLIENT��61   $��18(�5      $��DemiBold"�6   
���   �$��0q�5      ���#e59a9a$��Center=�5      $��Center=�64   � 5   
   -   5         �Name$ detailsGrid��5      $��1��6   $��10 0 0 0q�61   $
��Left=�6C   $	��Top=�6^    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6     � 	Resources 5'       �� 
TargetType �� Property �� Value��%c  '��       '�� �     �� 5(      " ��6   .�5)      ��  � ��$ 3q�6/   �� 5*       � ��$
 Left=�6<   �� 5+       � ��$ Center=�6:   5,      �� 5-      " ��6   .�5.      ��  � ��$ 3q�6/   �� 5/       � ��$	 220��6.   �� 50       � ��$
 Left=�6<   �� 51       � ��$ Center=�6:   52      53      .+�55      �� $��Cod Client:��6   $��0��6*   $��0��67   �� 56      -   5        	 ��Name$	 codclientTextBox��56      $��0��60   $��1��6=   ��6M   �� *	CodClient+�� 58      $��Nume Client:��6   $��1��6+   $��0��68   �� 59      -   5        $	 numeclientTextBox��59      $��1��61   $��1��6>   ��6N   �� *Nume+�� 5;      $��Persoana De Contact:��6   $��2��63   $��0��6@   �� 5<      -   5        $	 persoanacontactTextBox��5<      $��2��66   $��1��6C   ��6S   �� *PersoanaContact+�� 5>      $��Telefon:��6   $��3��6'   $��0��64   �� 5?      -   5        $	 telefonTextBox��5?      $��3��6.   $��1��6;   ��6K   �� *	Telefon+�� 5A      $��Adresa:��6   $��4��6&   $��0��63   �� 5B      -   5        $	 adresaTextBox��5B      $��4��6-   $��1��6:   ��6J   �� *Adresa+�� 5D      $��Oras:��6   $��5��6$   $��0��61   �� 5E      -	   5        $	 orasTextBox��5E      $��5��6+   $��1��68   ��6H   �� *Oras+�� 5G      $��Judet:��6   $��6��6%   $��0��62   �� 5H      -
   5        $	 judetTextBox��5H      $��6��6,   $��1��69   ��6I   �� *Judet+5K      �� 5L   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   $��Center=�6;    5M      ��%u   '��       �� 5N      " ��6   .�5O      ��  � ��$ 74��6.   �� 5P       � ��$ 8q�6/   5Q      5R      .+�5T      �� -   5         ��Name$ buttonOK��5T      $��OK��6'   64   �� 5U      -   5        $ buttonCancel��5U      $��Anulare��6+   6=   5V      5W      5X      