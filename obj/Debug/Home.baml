   M S B A M L   `   `   `  ����C  ?CRMFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CRMFinalCRMFinal  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   W       CRMFinal.Home   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:CRMFinal     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >Wpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  6W   $��673.701��5	   7   $��1233.629��6H   
�������.��5
      � 
�������$��1215.629��6   $��673.701��6/     � ColumnDefinitions  5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��1��6+   
������� "  PrimaryHueLightForegroundBrush#���   5      $��8q�5      $��0,0,802.129,0q�6   $��317.201��62   .��5      �� $��18(�5      $��10,10,59,27q�6   $��Raleway SemiBold)�64   �� 6S   $�Sales Pipeline��6W   6p   5      #  LiveCharts.Wpf.CartesianChart  5   
   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$	 Top=�6A   $��1��6V   $
��Left=�6f   $��253.201��6�   $��	10,51,0,0q�6�   $��1��6�   $	��Top=�6�   $��349.5��6�      Series 6   �� *SeriesCollection+   AxisY 5         LiveCharts.Wpf.Axis     Title$ Sales��6      LabelFormatter 6)   �� *
yFormatter+   AxisX 5#        $ Month��6    6)   �� *
xFormatter+5%        5&   
   $��1��6   $��1��6+   
�������#���   5(      $��8q�5)      $��400.5,1.667,466.629,0q�6   $��317.201��68   .��5*      �� $��18(�5+      $��10,10,0,28.5q�6   $��Raleway SemiBold)�65   �� 6T   $�My Open Leads��6X   6p   5-        LiveCharts.Wpf.PieChart  5.   
   -   5        $��1��5.      $
��Left=�6'   $��242.368��6B   $��429,72.463,0,0q�6S   $��1��6k   $	��Top=�6x   $	��271��6�    50        LiveCharts.Wpf.PieSeries    LiveCharts.Wpf.Series   Title$ 	Ownership��6    	   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$	 35 62   
   
DataLabels
 .    
LabelPoint 6P   �� *
PointLabel+  51      $ 	Converted��6    $	 25 62   
 .  6P   �� *
PointLabel+  52      $ Source��6    $	 40 6/   
 .  6M   �� *
PointLabel+57      �� 58   
   $��1��6   $��1��6!    * &MaterialDesignFloatingActionMiniButton#��[ 59      $
��Left=�5:       � ToolTip$, &MaterialDesignFloatingActionMiniButton��5;      $��412,52.463,0,569.238q�6>   $
��Auto��6\   $��12��6j   ���	#FF2195F2���	#FF2195F26�   �� 5<   
   $��1 - OWNERSHIP��6   $��1��6)   $��429,51.13,657.629,566.238q�69   $��1��6\   $��11(�6i   �� 5=   
   $��2 - CONVERTED��6   $��1��6)   $#��537.667,51.13,549.629,566.238q�69   $��1��6`   $��11(�6m   �� 5>   
   $��
3 - SOURCE��6   $��1��6&   $��643,51,466.629,566.368q�66   $��1��6V   $��11(�6c    J� RenderTransformOrigin$ 0.896,0.339&�6q   �� 5?   
   $��1��6   $��1��6!   #��[ 5@      $
��Left=�5A      $, &MaterialDesignFloatingActionMiniButton��5B      $��518,52.463,0,569.238q�6>   $
��Auto��6\   $��12��6j   ���	#FFFEC007���	#FFFEC007$ -1.694,0.767&�6�   �� 5C   
   $��1��6   $��1��6!   #��[ 5D      $
��Left=�5E      $, &MaterialDesignFloatingActionMiniButton��5F      $��626,52.333,0,569.368q�6>   $
��Auto��6\   $��12��6j   ���	#FFF6724D���	#FFF6724D$ -2.667,0.309&�6�     5G   
   $��1��6   $��1��6+   
�������#���   5I      $��8q�5J      $��724.5,0,0,0q�6   $��224.201��6.   .��5K      �� $��18(�5L      $��10,10,59.629,16.5q�6   $��Raleway SemiBold)�6:   �� 6Y   $&� Key Deals - Recent Opportunities��6]   6�   5M      �� 5N   
   $>��8No deals yet. Select another filter or check back later.��6   $$��775.722,117.339,43.907,496.362q�6T   $��1��6|   $��1��6�   $��Raleway SemiBold)�6�   $��14(�6�     5O   
   $��1��6   $��1��6+   
�������#���   5Q      $��8q�5R      $��0,340.5,466.629,0q�6   $��164.201��64   .��5S      �� $��18(�5T      $��10,10,21.629,16.5q�6   $��Raleway SemiBold)�6:   �� 6Y   $�
Activities��6]   6r   5U        5V   
   $��1��6   $��1��6+   
�������#���   5X      $��8q�5Y      $��724.5,244.5,0,0q�6   $��260.201��62   .��5Z      �� $��18(�5[      $��10,10,21.629,16.5q�6   $��Raleway SemiBold)�6:   �� 6Y   $�Today's Tasks��6]   6u   5\      �� 5]   
   $��images/notasks.PNG��6   $��737.453,291.5,21.907,169q�6,   $��1��6N   $��1��6^   $
��Fill=�6k   �� 5^   
   $=��7Nothing due today. Be a go-getter, and check back soon.��6   $ ��775.722,455.701,43.907,158q�6S   $��1��6w   $��1��6�   $��Raleway SemiBold)�6�   �� 5_   
   $��No Activity Available��6   $��174,422.701,645.629,191q�61   $��1��6R   $��1��6b   $��Raleway SemiBold)�6o   $��Center=�6�   5b      5d      