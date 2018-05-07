function main() {
	var binary;
	var n = parseInt(readLine());
	var firstCount = 0;
	var finalCount = 0;
	binary = n.toString(2);
	for (var i = 0; i < binary.length; i++) {
		if (binary.charAt(i) == 1) {
			firstCount++;
			if (firstCount > finalCount) {
				finalCount = firstCount;
			}
		} else if (binary.charAt != 0) {
			firstCount = 0;
		}
	}
	console.log(finalCount);
}