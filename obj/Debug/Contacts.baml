   M S B A M L   `   `   `  ����C  ?CRMFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CRMFinalCRMFinal  5          CRMFinal.Contacts   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:CRMFinal     5      $��673.701��5   7   $��1233.629��6H   
�������.��5	      � ���	#FFF9F9F9  � ColumnDefinitions  5
   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��100 �6   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $��70 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $��10 �6   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��Contacts��6   $��1��6$   $��2��64   $��24(�6A   $��Raleway SemiBold)�6O   $��0,19,0,0q�6m   &   System.Windows.Controls.DataGrid  5    
   -   5        $��
ContactDgd��5    �      AutoGenerateColumns .  $��3��6�   $��1��6�   $��Raleway SemiBold)�6�   $��12(�6�   $��7��6�   $��1q�6   ���	#FF9B9B9B   GridLinesVisibility$ 
Horizontal=�6,     VerticalGridLinesBrush �	#FF323232   HeadersVisibility$ Column=�6p     AlternatingRowBackground �	#FFE4E4E4
���������6y   ��    Columns 5!      4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$	 All��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 70 66   6C   0  *System.Windows.Controls.DataGridTextColumn  5$      -   5        ContactName��$ CONTACT NAME��5$   :   $		 150 6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6\   �� *	FirstName+6~     5%      -   5        Account��$ ACCOUNT��5%   6   $		 120 6G   
 6S   �� *AccountName+6w     5&      -   5        Company��$ COMPANY��5&   6   $		 100 6G   
 6S   �� *CompanyName+6v     5'      -   5        JobTitle��$ 	JOB TITLE��5'   7   $		 100 6J   
 6V   �� *
JobTitle+6v     5(      -   5        Industry��$ INDUSTRY��5(   7   $		 110 6I   
 6U   �� *
Industry+6u     5)      -   5        	Email��$ EMAIL��5)   4   $		 150 6C   
 6O   �� *Email+6l   5  /System.Windows.Controls.DataGridHyperlinkColumn  5*      -   5        	ContactNo��$ 
CONTACT NO��5*   =   $		 110 6Q   
 6]   �� *	ContactNo+6~     5+      -	   5        Address��$ ADDRESS��5+   7   $		 150 6H   
 6T   �� *	Address+6s   5.      �� 5/   
   -
   5        $��
AddContact��5/   *   $	��ADD��6<   $��3��6J   $��2��6Z   $
��Auto��6g   $
��0,10q�6u   �� 50   
   -   5        $��	btnDelete��50      $��DELETE��6:   $��5��6K   $��2��6[   $
��Auto��6h   $
��0,10q�6v   ���	#FFFF3E3E��6�   Z� �� 51   
   $��2��6   $��1��6    $��153,14,0,12q�60   $��34��6E   $��0,0,0,1q�6Q   .@�52      ��  �� 
IsSelected . .��53   $   All Contacts55      �� 56      .��6   Recently Created58      �� 59      .��6   Recently Modified5;      �� 5<      .��6   New this week5>      �� 5?      .��6   New Last Week5A      5B      �� 5C   
   $��PRINT��6   $��7��6!   $��2��61   $
��Auto��6>   $
��0,10q�6L   ���	#FFF9813D��6q   Z� 5D      5E      