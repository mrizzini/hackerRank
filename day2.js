function main() {
    var meal_cost = parseFloat(_input[0]);
    var tip_percent = parseFloat(_input[1]/100);
    var tax_percent = parseFloat(_input[2]/100);
    var tip_cost = meal_cost * tip_percent;
    var tax_cost = meal_cost * tax_percent;
    var total_cost = (meal_cost + tip_cost + tax_cost);
    total_cost = Math.round(total_cost);
    console.log("The total meal cost is " + total_cost + " dollars.");
}

main();