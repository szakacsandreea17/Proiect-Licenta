   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SzakacsAndreea_2023_LicentaSzakacsAndreea_2023_Licenta  5   	   ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5	   	   ,    &SzakacsAndreea_2023_Licenta.HomeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   5local)clr-namespace:SzakacsAndreea_2023_Licenta  5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5	   	   -   5          � Title$  
HomeWindow��5   	   $	��700��6   $
��1500��6)    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $y�Visible=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   $��5q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #3e0f0f��6    � Offset$ 0Q�6/   � 5      $ #3e0f0f��6   $
 0.75Q�6/   � 5      $ #e6e6e6��6   $ 1Q�6/   5      ._�5   
   � 	 � ColumnDefinitions	 5       �� 5"      $	��250 �6#   �� 5$      $��* �6#   .+�5'      �� $ 	10 0 0 10��6   $��0��5(      ��5)      �� 5*         navigationmenuColor1
 �� Color#
 [  6'   ._�5.      �� .+�50      ��  �� Orientation$ 
Horizontal=�6!   $	��230��51   !   $��	15 10 0 0q�52   !   $��Center=�53   !   .+�54      �� $��Images/emblema.png��6    $	��230��6<   $	��250��6I   55      	� 58      -   5         	�Name$ btnPaginaPrincipala��58   "     
menuButton#��[ 6?    
 color1
 � Tag# [ 59   "   .��5<      �� $ 
Horizontal=�6%   .+�5=      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 5>      $��Pagina Principala��6(     menuButtonText#��[ 6A   5?      5@      	� 5B      -   5        #��[ 5B   "    
 color2# [ 5C   "   .��5E      �� $ 
Horizontal=�6%   .+�5F        $ 	UserGroup=�6+   #��[ 6<   �� 5G      $��Clienți��6(   #��[ 67   5H      5I      	� 5K      -   5        $ OrdersButton��5K   "   #��[ 68    
 color3# [ 5L   "   .��5N      �� $ 
Horizontal=�6%   .+�5O        $ ShoppingCart=�6+   #��[ 6?   �� 5P      $��Comenzi��6(   #��[ 67   5Q      5R      	� 5T      -   5        $ btnDitribuitori��5T   "   #��[ 6;    
 color4# [ 5U   "   .��5W      �� $ 
Horizontal=�6%   .+�5X        $ Truck=�6+   #��[ 68   �� 5Y      $��Distribuitori��6(   #��[ 6=   5Z      5[      	� 5]      -   5        $ btnProducatori��5]   "   #��[ 6:    
 color5# [ 5^   "   .��5`      �� $ 
Horizontal=�6%   .+�5a        $	 Box=�6+   #��[ 66   �� 5b      $��Producatori��6(   #��[ 6;   5c      5d      	� 5f      -   5        $ 
btnProduse��5f   "   #��[ 66    
	 color6# [	 5g   "   .��5i      �� $ 
Horizontal=�6%   .+�5j        $ ProductHunt=�6+   #��[ 6>   �� 5k      $��Produse��6(   #��[ 67   5l      5m      	� 5p      -   5        $ btnSortimente��5p   "   #��[ 69    

 color9# [
 5q   "   .��5s      �� $ 
Horizontal=�6%   .+�5t        $ Shapes=�6+   #��[ 69   �� 5u      $��
Sortimente��6(   #��[ 6:   5v      5w      	� 5{      -	   5        $ btnDeconectare��5{   "   #��[ 6:    
 color8# [ 5|   "   .��5~      �� $ 
Horizontal=�6%   .+�5        $ SignOut=�6+   #��[ 6:   �� 5�      $��Deconectare��6(   #��[ 6;   5�      5�      5�      5�      �� 5�      $ 	0 10 10 0��6   $��1��5�      ��5�      �� 5�        primaryBackColor1#
 [ 6&   ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6(   �� 5�      $��* �6(   .+�5�      �� -
   5         ��Name$ pnlControlBar��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   ���#b3b3b3$��0 0 0 0q�5�   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !     colorcontrolbutton# [ 5�   !   .��5�        $ Xmark=�6+     controlButtonIcon#��[ 68   5�      �� 5�      -   5        $ btnMaximize��5�   !   #��[ 5�   !   # [ 5�   !   .��5�        $ WindowMaximize=�6+   #��[ 6A   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��[ 5�   !   # [ 5�   !   .��5�        $ WindowMinimize=�6+   $��12��6A   #��[ 6L   5�      5�      � 5�      $��2��6   .+�5�       � -   5        $��	workspace��5�       $��5 5 5 5q�61     � NavigationUIVisibility$ Hidden=�6C   
�������6c   5�      5�      5�      5�      5�      5�      