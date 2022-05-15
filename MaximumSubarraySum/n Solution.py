import time


def solution(array):
    value = 0
    _sum = 0
    n = len(array)
    for k in range(n):
        _sum = max(array[k], _sum+array[k])
        value = max(value, _sum)
    return value


if __name__ == '__main__':
    arr = [int(n) for n in input().split()]

    start = time.time()

    _max = solution(arr)
    print("maximum subarray sum :", _max)
    print("time :", "{:.10f}".format(time.time() - start))
