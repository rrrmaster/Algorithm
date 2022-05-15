import time


def solution(array):
    value = 0
    n = len(array)
    for a in range(n):
        for b in range(n):
            value = max(value, sum(array[a:b]))
    return value


if __name__ == '__main__':
    arr = [int(n) for n in input().split()]

    start = time.time()

    _max = solution(arr)
    print("maximum subarray sum :", _max)
    print("time :", "{:.10f}".format(time.time() - start))
