echo " how many distinct coupon you want to generate:"
read n
generatecoupon(){
small=({a..z})
big=({A..z})
while (( $n > 0 ))
do 
          a=$(shuf -i 0-25 -n 1)
          b=$(shuf -i 0-25 -n 1)
          random1=$(shuf -i 0-25 -n 1)
          random2=$(shuf -i 0-25 -n 1)
          random3=$(shuf -i 100-1000 -n 1)
          random4=$(shuf -i 1000-2000 -n 1)
          echo -ne "\r coupon number $n is:"
          echo $b$random4${small[$random1]}$random4${big[$random2]}$random3${small[$a]}
          n=$((n-1))
done
}
generatecoupon
