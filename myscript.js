function calculateDaysBetweenDates(begin, end) {
  return Math.round((end - begin) / (1000 * 60 * 60 * 24));
}

console.log(calculateDaysBetweenDates(new Date(2019, 0, 1), new Date(2019, 0, 31)));