countwin=0
countloss=0

gambling(){

echo -e "enter Stack:\c"
read stack
echo -e "how much money you want to make:\c"
read goal
echo -e "enter number of trials:\c"
read trials
echo "enter the bet amount:\c"
read bet

while (( $(( $stack > 0 )) && $(( $trials > 0)) && $(( $goal  != $stack )) ))
do
if (( $bet > $stack ))
  then
   echo "money limit can't be exceeded "
   break
  
      else 
       rd=$( shuf -i 0-10 -n 1 )
            if (( rd > 5 ))
             then 
             stack=$(($stack + $bet))
               countwin=$((countwin + 1 ))

             if (( $goal == $stack ))
              then 
                break
              fi
             else 
           stack=$(($stack - $bet ))
          countloss=$(( countloss + 1 ))
         fi
     fi
    done
echo "you won $countwin times "
echo "you loss $countloss times"

winper=$( awk -v a=$countwin -v b=$(($countwin+$countloss)) 'BEGIN{print(a/b)*100}')
echo "win percentage: $winper"
lossper=$(awk -v a=$countloss -v b=$(($countloss + $countwin)) 'BEGIN{print(a/b)*100}')
echo "loss percentage:$lossper"
}


gambling
