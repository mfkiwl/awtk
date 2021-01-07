a=typed_array_create("i8", 10)

assert(typed_array_push(a, 1,2,3) == 3);
assert(typed_array_get_size(a), 3);

assert(typed_array_push(a, 4) == 1);
assert(typed_array_get_size(a), 4);

assert(typed_array_clear(a));
assert(typed_array_get_size(a) == 0);

unset(a);
