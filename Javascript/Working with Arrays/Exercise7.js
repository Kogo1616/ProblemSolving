Array.prototype.filter = function(predicateFunction) {
    var results = [];
    this.forEach(function(itemInArray) {
        results.push(predicateFunction(itemInArray))
    });

    return results;
};

// JSON.stringify([1,2,3].filter(function(x) { return x > 2})) === "[3]"
		