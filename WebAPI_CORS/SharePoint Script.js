<script>
		
		//var apiUrl = _spPageContextInfo.webAbsoluteUrl + "/_api/web/lists/getbytitle('" + "Abhi" + "')/items";
		var apiUrl = "https://abhisheksamolewebapi.azurewebsites.net/customer";
        debugger;
		$.ajax({
	        url: apiUrl,
	        type: "GET",
	        headers: { 
	        	"Accept": "application/json; odata=verbose",
	        	"Content-Type": "application/json;odata=verbose"
	        },
	        success: function (data) {
	        	console.log(data);
	        },
	        error: function (result) {
	            console.log("Failed to get data");
	        }
    	});
    	
</script>