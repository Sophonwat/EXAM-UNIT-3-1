import json

# Load the books data from the JSON file
with open('books.json') as f:
    books = json.load(f)

def books_starting_with_the(books):
    return [book for book in books if book['title'].startswith('The')]

def books_with_author_containing_t(books):
    return [book for book in books if 't' in book['author'].lower()]

def books_written_after_1992(books):
    return len([book for book in books if book['publication_year'] > 1992])

def books_written_before_2004(books):
    return len([book for book in books if book['publication_year'] < 2004])

def isbn_numbers_for_author(books, author):
    return [book['isbn'] for book in books if author.lower() in book['author'].lower()]

def sort_books_alphabetically(books, ascending=True):
    return sorted(books, key=lambda x: x['title'], reverse=not ascending)

def sort_books_chronologically(books, ascending=True):
    return sorted(books, key=lambda x: x['publication_year'], reverse=not ascending)

def group_books_by_author_last_name(books):
    grouped_books = {}
    for book in books:
        last_name = book['author'].split()[-1]
        if last_name in grouped_books:
            grouped_books[last_name].append(book)
        else:
            grouped_books[last_name] = [book]
    return grouped_books

def group_books_by_author_first_name(books):
    grouped_books = {}
    for book in books:
        first_name = book['author'].split()[0]
        if first_name in grouped_books:
            grouped_books[first_name].append(book)
        else:
            grouped_books[first_name] = [book]
    return grouped_books

# Example usage
the_books = books_starting_with_the(books)
t_author_books = books_with_author_containing_t(books)
after_1992_count = books_written_after_1992(books)
before_2004_count = books_written_before_2004(books)
author_isbns = isbn_numbers_for_author(books, 'Terry Pratchett')
alphabetically_sorted_books = sort_books_alphabetically(books)
chronologically_sorted_books = sort_books_chronologically(books)
books_grouped_by_last_name = group_books_by_author_last_name(books)
books_grouped_by_first_name = group_books_by_author_first_name(books)

# Printing results for demonstration
print("Books starting with 'The':", len(the_books))
print("Books with authors containing 't':", len(t_author_books))
print("Books written after 1992:", after_1992_count)
print("Books written before 2004:", before_2004_count)
print("ISBN numbers for Terry Pratchett:", author_isbns)
print("Alphabetically sorted books:")
for book in alphabetically_sorted_books:
    print(book['title'])
print("Chronologically sorted books:")
for book in chronologically_sorted_books:
    print(book['title'], book['publication_year'])
print("Books grouped by last name:")
for last_name, books in books_grouped_by_last_name.items():
    print(last_name, "-", len(books))
print("Books grouped by first name:")
for first_name, books in books_grouped_by_first_name.items():
    print(first_name, "-", len(books))
