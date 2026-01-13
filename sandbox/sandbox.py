from cse351 import *

import time
import threading

def add_two(x, results):
    answer = x + 2
    results.append(answer)

def main():

    results = []

    t = threading.Thread(tareget=add_two, args=(10, results))

    t.start()

    t.join()

    print(results)

if __name__ == "__main__":
    main()
