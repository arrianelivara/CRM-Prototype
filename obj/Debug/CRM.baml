   M S B A M L   `   `   `  ����C  ?CRMFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CRMFinalCRMFinal  5   	   9!clr-namespace:CRMFinal.PropertiesCRMFinal.Properties  5   	       CRMFinal.CRMain   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CRMFinal     5   	   8
Properties!clr-namespace:CRMFinal.Properties     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>     � Title$  CRMain��5	   	   $��673.701��6   $��1233.629��6)    � WindowStartupLocation$ CenterScreen=�6:   .��5
      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $��60 �6#   �� 5      $
��118* �6#   �� 5      $	��118 �6#   �� 5      $
��118* �6#   �� 5      $
��118* �6#   �� 5      $
��118* �6#   �� 5      $
��130* �6#   �� 5      $
��129* �6#   �� 5      $��60 �6#   �� 5      $��60 �6#   �� 5      $��60 �6#   �� 5      $��60 �6#   �� 5      $��20 �6#    � RowDefinitions 5      �� 5      $��5 �6    �� 5       $��60 �6    �� 5!      $��* �6    .+�5#      ]� $��1��6   ���	#FF173835$��13��6=   ]� 5%      $��0��6   ���	#FF10D6A0$��13��6=   �� 5&      $��images/zogo.png��6   $
��Auto��6-   $��1��6;   $��UniformToFill=�6H   $��-10.5,5,115.641,572.701q�6`   $��2��6�   $��2��6�   �� 5'      -   5         ��Name$ btnLeads��5'      $��1��6'   $��2��64   $��Leads��6D   $
��Auto��6T   ���	#FF173835$��14(�6y   $��Raleway SemiBold)�6�   ���	#FF1738356�   �� 5(      -   5        $ btnContacts��5(      $��1��6*   $��3��67   $��Contacts��6G   $
��Auto��6Z   ���	#FF173835$��14(�6   $��Raleway SemiBold)�6�   ���	#FF1738356�   �� 5)      -   5        $ btnDeals��5)      $��1��6'   $��4��64   $��Deals��6D   $
��Auto��6T   ���	#FF173835$��Raleway SemiBold)�6y   $��14(�6�   ���	#FF1738356�   �� 5*      -   5        $ btnActivities��5*      $��1��6H   $��5��6U   $��
Activities��6e   $
��Auto��6z   ���	#FF173835$��Raleway SemiBold)�6�   $��14(�6�   ���	#FF1738356�   �� 5+      -   5        $ btnHome��5+      $��1��6<   $��1��6I   $
��Home��6Y   $
��Auto��6h   ���	#FF173835$��14(�6�   $��Raleway SemiBold)�6�   ���	#FF1738356�   �� 5,      $��1��6   $��9��6!   $��Images\calendar.png��61   $��10,10,10,12q�6N   �� 5-      $��1��6   $��10��6!   $��Images\notification.png��62   $��10,10,10,12q�6S   �� 5.      $��1��6   $��11��6!   $��Images\userman.png��62   $��10,10,10,12q�6N   d� 5/      -   5         d�Name$ toggleButton��5/   e   $��1��6   $��9��6(   {�.  J� Opacity$
 0.05Q�6{   (  "MaterialDesignThemes.Wpf.ColorZone  52         Mode$ Standard=�53   	   $��8 4 8 4q�54   	      CornerRadius$ 2��55   	   	 K� ZIndex$	 1��56   	   $��53.731,10.472,0,0q�57   	   +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth1=�58   	   $��3��6:   $��39��6N   $��6��6Z   $��1��6j   .��59      �  5:      �� 5;      $
��Auto �5<      �� 5=      $��* �5>      �� 5?      $
��Auto �5@      .+�5B      ��    MaterialDesignToolButton#���   5C      .��5D      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�5E      $	 .56Q�5F      5G      �� 5H      $��1��5I      $��8 0 0 0q�5J      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5K      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5L      $��0q�5M      $	��200��5N      $��Center=�5O      �� 5P      #���   5Q      $��2��5R      .��5S        $ 
Microphone=�5T      $	 .56Q�5U      $��8 0 0 0q�5V      5W      5X      5Y      5]         CRMFinal.UserControl1  5^   
   -   5          Name$ Activities1��5^      $
��Auto��62   $��0,65,0,-143.64q�6@   $
��Auto��6X      CRMFinal.Lead  5`   
   -   5          Name$ Leads1��5`      $��577.701��6%   $��0,65,0,0q�66   $	��Top=�6H   $
��Auto��6`   	   CRMFinal.Contacts	  5a   
   -	   5         	 Name$ 	Contacts1��5a      $
��Auto��6-   $��0,65,0,0q�6;   $
��Auto��6M   
   CRMFinal.Deals
  5b   
   -
   5         
 Name$ Deals1��5b      $
��Auto��6&   $��0,65,0,0q�64   $
��Auto��6F      CRMFinal.Home  5c   
   -   5          Name$ Home1��5c      $
��Auto��6$   $��0,65,0,0q�62   $
��Auto��6D   &   System.Windows.Controls.Calendar  5e   
   -   5          Name$
 date��5e      $��872,65,74,221q�6!   ���	#DD000000$y�Hidden=�6O   5f      5g      