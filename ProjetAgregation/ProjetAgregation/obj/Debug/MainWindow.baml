   M S B A M L   `   `   `  ����K  GProjetAgregation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjetAgregationProjetAgregation  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    ProjetAgregation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjetAgregation     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
Agregation��5	   	   $	��450��6   $	��800��6)   
���  ��.��5
      � 
���   �.+�5   
   �� $
��Left=�6   $��23��6-   $��
331,10,0,0q�69    �� TextWrapping$
 Wrap=�6M   $
��Menu��6a   $	��Top=�6m   $	��120��6�   
��� ���$��15(�6�    �� TextAlignment$ Center=�6�    �� 
IsReadOnly . 6�   �� 5   
   $
��Left=�6   $��23��6-   $��	24,10,0,0q�69   $
 Wrap=�6L   $	��Top=�6�   $	��120��6�   
��� ���$��12(�6  $ Center=�6   . ��6`   �� 
 �� Now �� Source# Z  �� Mode$ OneWay=� �� StringFormat$ yyyy-MM-dd HH:mm:ss ��6'  �� 5   
   $
��Left=�6   $��23��6-   $��
635,10,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   
��� ���$��15(�6�   $ Center=�6�    . ��6a   ��   System.Environment   UserName# Z $ OneWay=�6
  � 5   
   
���  ��$	��355��6    $��0,73,-0.4,0q�6-   	 � RowDefinitions	 5      �� 5      $
��150* �6    �� 5      $
��150* �6    
 � ColumnDefinitions
 5      �� 5      $	��200 �6#   �� 5      $
��200* �6#   �� 5      $
��200* �6#   �� 5      $
��200* �6#   .+�5      �� -   5        $��Acueil��5      $��Center=�6&   $��Center=�6C   $	��150��6^   $	��150��6j   
��� ���$��30(�6�   $��0��6�   �� 5      -   5        $
��Amis��5      $��Center=�6$   $��Center=�6B   $	��150��6]   $	��150��6i   
��� ���$��30(�6�   $��1��6�   �� 5      -   5        $��Email��5      $��Center=�6%   $��Center=�6C   $	��150��6^   $	��150��6j   
��� ���$��30(�6�   $��2��6�   �� 5      -   5        $��Graph��5      $��Center=�6%   $��Center=�6C   $	��150��6^   $	��150��6j   
��� ���$��30(�6�   $��3��6�   �� 5      -   5        $
��News��5      $��Center=�6$   $��Center=�6B   $	��150��6]   $	��150��6i   
��� ���$��30(�6�   $��3��6�   $��1��6�   �� 5       -   5        $
��Chat��5       $��Center=�6$   $��Center=�6A   $	��150��6\   $	��150��6h   
��� ���$��30(�6�   $��2��6�   $��1��6�   �� 5!      -   5        $��Pokemon��5!      $��Center=�6'   $��Center=�6E   $	��150��6`   $	��150��6l   
��� ���$��30(�6�   $��1��6�   $��1��6�   �� 5"      -   5        $��Crypto��5"      $��Center=�6&   $��Center=�6D   $	��150��6_   $	��150��6k   
��� ���$��30(�6�   $��0��6�   $��1��6�   5#      5$      5%      