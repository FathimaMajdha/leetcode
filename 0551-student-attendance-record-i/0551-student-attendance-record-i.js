/**
 * @param {string} s
 * @return {boolean}
 */
var checkRecord = function(s) {
    let Absent=0;
    let Late=0;
    for(let i=0;i<s.length;i++){
        if(s[i]== 'A'){
            Absent++;
            if(Absent>1){
                return false;
            }
        }
        if(s[i]=='L'){
            Late++;
            if(Late>=3){
               return false;
           
            }
        }else{
           Late=0;
        }
        

    }  
    return true;
};