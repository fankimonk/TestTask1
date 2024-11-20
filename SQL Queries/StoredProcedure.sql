create procedure GetSumAndMedian
	@sum_out bigint output,
    @median_out decimal(18,8) output
as
begin
    declare @suminteger bigint;
    declare @median decimal(18,8);

    select @suminteger = sum(cast(Integer as bigint)) from filelines;

    ;with ordered as (
        select floatingpointnumber,
               row_number() over (order by floatingpointnumber) as rowasc,
               row_number() over (order by floatingpointnumber desc) as rowdesc
        from filelines
        where floatingpointnumber is not null
    )
    select @median = avg(floatingpointnumber * 1.0)
    from ordered
    where rowasc = rowdesc
       or rowasc + 1 = rowdesc;

    select @suminteger as IntegerSum, @median as Median;

	SET @sum_out = @suminteger;
    SET @median_out = @median;
end;

exec GetSumAndMedian

drop procedure GetSumAndMedian