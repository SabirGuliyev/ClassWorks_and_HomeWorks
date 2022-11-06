const numbers = [2,1,54,65,343,64,-15,3,2,3,4,5]
// let minNum = numbers[0];
// let maxNum = numbers[0];
let minIndex = 0;
let maxIndex = 0;

for (let i = 0; i < numbers.length; i++) {
    if(numbers[i] < numbers[minIndex]){
        // minNum = numbers[i];
        minIndex = i;
    }else if(numbers[i] > numbers[maxIndex]){
        // maxNum = numbers[i];
        maxIndex = i;
    }
}
numbers[minIndex] += numbers[maxIndex];
numbers[maxIndex]=numbers[minIndex]- numbers[maxIndex];
numbers[minIndex]-=numbers[maxIndex]

// [numbers[minIndex] , numbers[maxIndex]] = [numbers[maxIndex] , numbers[minIndex]]

console.log(numbers);