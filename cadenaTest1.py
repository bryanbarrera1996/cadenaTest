def isPrime(n):
    if n < 2:
        return False
    if n in (2,3):
        return True
    if n % 2 == 0 or n % 3 == 0:
        return False
    i = 5
    while i * i <= n:
        if n % i == 0 or n % (i + 2) == 0:
            return False
        i += 6
    return True

def sum_primes(list_numbers):
    if not isinstance(list_numbers, list) or not all(isinstance(x, int) for x in list_numbers):
         raise ValueError("Array must be a list of integers")
    
    return sum(x for x in list_numbers if isPrime(x))

numbers = [1,2,3,4,5, 6, 7,8,9,10,20,23]
print(sum_primes(numbers)) # Result: 40