   M S B A M L   `   `   `  ����F  BTulpagotchi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TulpagotchiTulpagotchi  5   	       Tulpagotchi.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tulpagotchi     5   	     � Title$  Tulpagotchi��5   	   $	��600��6   $	��800��6*    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�  '��       '	� �     '��     �� 5
   
   " ��6   .�5      ��  � ��$ 40��6'   �� 5       � ��$	 120��6&   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   5      �� 5   
   " 	�6   .�5      ��  � ��$ 5q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 10q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ]� $��0��6   .+�5      o� $��Stretch=�6   $	��Top=�61   $
��Auto��6I   $	��Top=�6W   .@�5      m� $��_File��6   .@�5       m� -   5        $��_New Player��5       64   m� 5!      -   5        $��_Open Player��5!      65   �� 5"      m� 5#      -   5        $��_Save��5#      6.   m� 5$      -   5        $��Save _As��5$      61   �� 5%      m� 5&      -   5        $��E_xit��5&      6.   5'      m� 5(      -   5        $��_Preferences��5(      61   5)      5*      �� 5+   
   $��1��6   .@�5,      �� $��	Dashboard��6   .��5-      �  5.      �� 5/      �� 50       � ColumnDefinitions 52      �� 53      �� 54      .+�58      ]� -   5        $��BattleOptions��58       $��1��65   $��	20 0 0 20q�6C   $��Bottom=�6V   .+�59      	� -   5        $��battleOption_any��59   &   $��
Any battle��6>   $	��Top=�6S    d� 	IsChecked$
 TrueY�6h   	� 5:      -	   5        $��battleOption_mystery��5:   &   $��Find an unknown pet��6B   $	��Top=�6`   	� 5;      -
   5        $��battleOption_baby��5;   &   $��Train any baby pet��6?   $	��Top=�6\   	� 5<      -   5        $��battleOption_teenage��5<   &   $��Lecture any teenage pet��6B   $	��Top=�6d   5=      �� 5>      -   5        $��FightButton��5>      $��Let's Write!��60   $��1��6G   $��Right=�5?      $��Bottom=�69   $��	0 0 20 50q�6T   �� 5B      -   5        $��BattleWords��5B      $��1��61   $��2��6A   $y�	Collapsed=�6S   �� 5C      -   5        $��BattleImpage��5C   !   $��2��65   $y�	Collapsed=�6G   .+�5D      �� -   5        $��BattleEnemyImage��5D       $	��200��68   $)��#images/gen1/Teenager_Basic_Wolf.png��6E   �� 5E      -   5        $��BattleInfoLabel��5E       $��Boss Information��67   $��Center=�6R   $��0,15,0,0q�6o   � 5F      -   5        $��BattleProgress��5F   &   $��50��6<   $��
15 50 15 0q�6H   $	��Top=�6\   
���   �$��2q�6�   $	��100��5G   "    � Value$ 50Q�62   
�����p���5H      
� 5I   "   	 
� GradientOrigin$	 1,0.5&�66   
 
� Center$
 1,0.5&�6M    
� RadiusX$ 1Q�6\    
� RadiusY$ 1Q�6h   .��5J   &   �  � Color$ 	#FF0CFF00��63    � Offset$ 0Q�6E   � 5K   &   $ Black��63   $ 1Q�6A   5L   #   5N      �� 5O      $��XXX/XXXX words��6    $��Right=�69   $��0 0 15 0q�6U   5P      � 5Q      -   5        $��BattleControls��5Q       $��1��66   $��Stretch=�6C   $��Bottom=�6a   $y�	Collapsed=�6}   .+�5R      �� -   5        $��AbandonBattle��5R   !   $��Abandon��66   $��50 10q�6H   6W   �� 5S      -   5        $��	EndBattle��5S   !   $��
End Battle��62   6G   5T      5U      5V      �� 5W      $��
Collection��6   .��5X      �� .@�5Y      �� $��Standard Pets��6   �� 5Z      $��Milestone Pets��6   �� 5[      $��	Boss Pets��6   5\      5]      �� 5^      $��Milestones - COMING SOON��6   $y�	Collapsed=�68   �� 5_      $��Reports - COMING SOON��6   $y�	Collapsed=�65   5`      5a      5b      