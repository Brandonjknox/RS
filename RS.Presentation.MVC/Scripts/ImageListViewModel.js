function ImageListViewModel() {
    var self = this;
    self.fullImageList = ko.observableArray([]);
    self.viewingList = ko.observableArray([]);
    self.genreLists = ko.observableArray([]);
    self.selectedGenre = ko.observable('');
    //Functions
    self.Remove = function(item) {
        $.ajax({
            url: '/api/ImageValues',
            type: 'Delete',
            data:{id:item.Id}
        }).success(function() {
        self.fullImageList.remove(item);
        self.viewingList.remove(item);
           });
    };
    //Computed Events
    self.selectGenreChange = ko.computed(function () {
        if (self.selectedGenre() != "") {
            var lst = [];
            $.each(self.fullImageList(), function (index, image) {
                if (image.Genre.Id == self.selectedGenre()) {
                    lst.push(image);
                }
            });
            self.viewingList(lst);
        } else {
            self.viewingList(self.fullImageList());
        }

    });
    //load functions
    self.loadGenres = function (data) {
        data.unshift({ Id: 0, Name: "Please Select One" });
        self.genreLists(data);
    };


    self.loadImages = function (data) {
        self.fullImageList(data);
        self.viewingList(data);
    };
}