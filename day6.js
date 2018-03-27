function processData(input) {
	var even = [];
	var odd = [];
	//Enter your code here
	input = input.split("\n");
	for (var num = 1; num < input.length; num++) {
		for (var i = 0; i < input[num].length; i++) {
			if (i % 2 == 0) {
				even += input[num][i];
			} else {
				odd += input[num][i];
			}
		}
		console.log(even + " " + odd);
		var even = [];
		var odd = [];
	}
}