   M S B A M L   `   `   `  ���� Z  Vspanish-nl-analyzer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=fd183da8bf49ddb89!clr-namespace:spanish_nl_analyzerspanish_nl_analyzer  '    !spanish_nl_analyzer.FiltersWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:spanish_nl_analyzer       � Title$  Word Filters��$	��450��$	��800��.��� $
��12pxq� � ColumnDefinitions �� $��9* ��� $
��12px ��� $��1.25* � � RowDefinitions �� $��9* ��� $
��12px ��� $��* �.+��� -    ��Name$ filterWordsList��$��0��$��0��$��Center=�$��Center=�$	��Top=� �� View �� .P���  �� Width$ 25�� �� HeaderTemplate �� .R��� -    �� CellTemplate �� .R���  d� 	IsChecked �� 	 �� Path$	 
IsSelected�
 �� Mode$
 TwoWay=��� $
��Word��$	 610�� �� DisplayMemberBinding �� *Word+�� -   $��2��$��0��$��Delete��$
��Left=�$	��Top=�$��75�� � ToolTip$) #Delete selected words from filters.���� -   $��2��$��2��$	��Add��$
��Left=�$	��Top=�$��75��$A ;Add the entered words to the filters. (Phrases not allowed)�� J� RenderTransformOrigin$ 0.52,-2.053&��� -    ��Name$ newFilterWord��$��0��$��2��$
��Left=�$	��Top=� �� AcceptsReturn .   �� 
AcceptsTab .  $( "Press Enter to Create a New Filter��. �/� .T�J� .*�.*��� $�Type New Word Here��