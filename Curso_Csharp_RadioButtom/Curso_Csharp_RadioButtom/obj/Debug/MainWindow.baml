   M S B A M L   `   `   `  ����S  OCurso_Csharp_RadioButtom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Curso_Csharp_RadioButtomCurso_Csharp_RadioButtom  5   	   )    #Curso_Csharp_RadioButtom.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Curso_Csharp_RadioButtom     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.25* �6   6-   �� 5      $��* �6   6)   .+�5   
   � $��0��6   .+�5      ��  �� TextAlignment$ Center=�6   $��45(�6/   
����+��	Semáforo6_   	� 5      -   5        $��AllAcrivation��5      $��200,50,100,2q�6L   .��5      �� $��18(�6   Activar Todos6<   5      	� 5      -   5        $��Alldesactivation��5      $��450,50,100,2q�6R   .��5      �� $��18(�6   $��28��6+   Desctivar Todos6I   5      5      �� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6'   66   �� 5      $
��0.5* �6'   66   .+�5"      �� $��1��6   $��0��6*   .+�5$      	� -   5        $��50,25,50,75q�5$   "   .��5%      �� $��20(�6$   Rojo69   5&      	� 5(      -   5        $��50,25,50,75q�5(   "   .��5)      �� $��20(�6$   
Amarillo6>   5*      	� 5,      -   5        $��50,25,100,30q�5,   "   .��5-      �� $��20(�6$   Verde6:   5.      50      � 52      $��1��6   .+�53      �� $C��=C:\Users\sergio garcia michel\Pictures\cemaforo_encendido.jpg��6   6e   A� 54      -   5        $
��Rojo��54      $
��66.5��6+   $
��66.5��69   
���  ��$��151,38,179,230q�6Q   $y�Hidden=�6i   6   A� 55      -   5        $��Amarillo��55      $
��66.5��6.   $
��66.5��6<   
��� ���$��151,110,179,140q�6W   $y�Hidden=�6p   6�   A� 56      -   5        $��verde��56      $
��66.5��6+   $
��66.5��69   
��� � �$��151,199,179,69q�6S   $y�Hidden=�6k   6�   57      59      5:      5?      5@      