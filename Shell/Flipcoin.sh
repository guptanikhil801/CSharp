echo "enter number of flips"
read num
tails=0
heads=0
for(( i=1; i<=num; i++))
do
      randomnum=$( shuf -i 0-10 -n 1 )
        if (( randomnum < 5 ))
           then
           let tails++
           else
           let heads++
           fi
           done
headper=$( awk -v a=$heads -v b=$num ' BEGIN { print ( a/b * 100 ) } ' )
tailper=$( awk -v a=$tails -v b=$num ' BEGIN { print ( a/b * 100 ) } ' )
echo " head percentage is  $headper"
echo "tail percentage is $tailper"


