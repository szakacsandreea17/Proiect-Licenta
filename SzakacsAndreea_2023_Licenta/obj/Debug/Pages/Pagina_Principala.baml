   M S B A M L   `   `   `  ����V  RSzakacsAndreea_2023_Licenta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:SzakacsAndreea_2023_Licenta.Pages!SzakacsAndreea_2023_Licenta.Pages  5      ]3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer%SzakacsAndreea_2023_Licenta.DataLayer  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      9    3SzakacsAndreea_2023_Licenta.Pages.Pagina_Principala   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ;local/clr-namespace:SzakacsAndreea_2023_Licenta.Pages  5      C	DataLayer3clr-namespace:SzakacsAndreea_2023_Licenta.DataLayer  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5	      -   5          N� Title$  Pagina_Principala��5       � 	Resources 5         comandaViewSource �� Source��%+   &	        �� 5   
   $ Comanda��69   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��250 �6   �� 5      $	��400 �6   .+�5   
   �� -   5         ��Name$ 
labelTitle��5      $��0��6   $��PAGINA PRINCIPALA��61   $��18(�5      $��DemiBold"�6   
���   ����#e59a9a$��Center=�5       $��Center=�64   � 5"   
   $��1��6   .+�5#      �  � ColumnDefinitions 5$      �� 5%      $��1* �6#   �� 5&      $��1* �6#   �� 5'      $��1* �6#   .+�5)      � $��0��6   .+�5*      �� $	��120��6   $��20q�6,   
������� �� RadiusX$ 10��6J    �� RadiusY$ 10��6W   � 5+      $��25q�6   $	��120��6&   .+�5,      � $��35��6   ���	#FFFFAF24$��50��6=   $
��Left=�6I   $	��Top=�6d   $
��20 0q�6|    J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5.      	   
BlurRadius$	 20Q�6/   
   Color$

 gray��6?      RenderingBias$ Quality=�6L      Opacity$	 100Q�6d   .+�50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cart=�62   $��Center=�6>   $��Bottom=�6[   $��5q�6v   
���   �$��25��6�   $��25��6�   51      �� 52      $��NUMĂR TOTAL COMENZI��6    $��Center=�6;   $��Times New Roman)�6X   $��10q�6u   $	��Top=�6�   
���   �$��20(�6�   �� 53      -   5        $ labelcomenzi��53      $��Total records: ...��62   $��Center=�54      $��Center=�69   $��
20 40 0 10q�6T   $��50��6h   $��25(�6t   55      56      � 58      $��1��6   .+�59      �� $	��120��6    $��20q�6-   
�������$ 10��6K   $ 10��6X   � 5:      $��25q�6   $	��120��6'   .+�5;      � $��35��6   ���	#FFFFAF24$��50��6A   $
��Left=�6M   $	��Top=�6h   $
��20 0q�6�    5<        5=   "   $	 20Q�63   $

 gray��6C   $ Quality=�6P   $	 100Q�6h   .+�5?        $ AccountGroup=�66   $��Center=�6J   $��Bottom=�6g   $��5q�6�   
���   �$��25��6�   $��25��6�   5@      �� 5A      $��NUMĂR TOTAL CLIENȚI��6$   $��Center=�6?   $��Times New Roman)�6\   $��10q�6y   $	��Top=�6�   
���   �$��20(�6�   �� 5B      -   5        $ labelclienti��5B       $��Total records: ...��66   $��Center=�5C      $��Center=�69   $��
20 40 0 10q�6T   $��50��6h   $��25(�6t   5D      5E      � 5G      $��2��6   .+�5H      �� $	��120��6    $��20q�6-   
�������$ 10��6K   $ 10��6X   � 5I      $��25q�6   $	��120��6'   .+�5J      � $��35��6   ���	#FFFFAF24$��50��6A   $
��Left=�6M   $	��Top=�6h   $
��20 0q�6�    5K        5L   "   $	 20Q�63   $

 gray��6C   $ Quality=�6P   $	 100Q�6h   .+�5N        $ ContentCopy=�66   $��Center=�6I   $��Bottom=�6f   $��5q�6�   
���   �$��25��6�   $��25��6�   5O      �� 5P      $��TOTAL PRODUCATORI��6$   $��Center=�6=   $��Times New Roman)�6Z   $��10q�6w   $	��Top=�6�   
���   �$��20(�6�   �� 5Q      -   5        $ labelproducatori��5Q       $��Total records: ...��6:   $��Center=�5R      $��Center=�69   $��
20 40 0 10q�6T   $��50��6h   $��25(�6t   5S      5T      5V      5W      � 5X   
   $��2��6   $��10 10 10 70q�6   .+�5Y      #  LiveCharts.Wpf.CartesianChart  &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6E      Series 6!   �� *SeriesCollection+   AxisX 5\        LiveCharts.Wpf.Axis     Title$ Numar Comenzi��6      LabelFormatter 65   �� *	Formatter+6\      AxisY 5_        $
 Luna��6      Labels 6,   �� *Labels+6H      DataTooltip 5b      #  LiveCharts.Wpf.DefaultTooltip  5c         SelectionMode$ SharedYValuesX�6)   6I   5e      5g      5h      5i      