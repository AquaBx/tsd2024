# 1

def min_max(arr)

  if (arr.length != 5)
    raise "The array needs to be 5 numbers long exactly"
  end

  arr2 = arr.sort()

  mini = 0
  maxi = 0

  for i in 0..3
    mini += arr2[i]
    maxi += arr2[arr2.size - 1 - i]
  end

  puts [mini,maxi].inspect
end

min_max([1, 2, 3, 4, 5])  # 10 14
min_max([2, 8, 3, 5, 1])  # 11 18

# 2

def decimal(str)
  total = 0
  i = str.length - 1
  str.each_char do|c|
    if c=='0'
      total += 0
    elsif c=='1'
      total += 2 ** (i)
    else  
      raise "Not binary"
    end
    i-=1
  end
  total
end


puts decimal("101")  # 5
# puts decimal("231")  # ArgumentError: this is not a binary number

# 3

def count_words(str)
  map = Hash.new(0)

  str.split(" ").each do |item|
    map[item] += 1
  end

  puts map
end

count_words("olly olly come here free")
# output (just hash, not a printed string):
# {
#   olly: 2,
#   here: 1,
#   come: 1,
#   free: 1,
# }

# 4

def pangram?(str)
  map = Hash.new(0)
  str.downcase.each_char do|c|
    map[c] = 1
  end

  "abcdefghijklmnopqrstuvwxyz".each_char do|c|
    if map[c]==0
      return false
    end
  end 

  return true
end

puts pangram?("The quick brown fox jumps over the lazy dog.")  # true
puts pangram?("abde")                                          # false
