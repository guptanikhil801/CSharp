echo "enter a, b, c"
read a
read b
read c
delta=$( awk -v x=$a -v y=$b -v z=$c 'BEGIN { print ( y*y - 4*x*z ) } ' )
sqroot=$( awk -v x=$delta 'BEGIN { print ( sqrt(x) ) } ' )
root1=$( awk -v x=$a -v y=$b 'BEGIN { print ( (-y+sqroot)/ 2*x ) } ' )
root2=$( awk -v x=$a -v y=$b 'BEGIN { print ( (-y-sqroot)/ 2*x ) } ' )
echo "root1 is $root1, root 2 is $root2"
